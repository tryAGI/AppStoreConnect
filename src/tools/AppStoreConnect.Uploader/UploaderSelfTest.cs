using System.Net;
using System.Text;
using System.Text.Json;

namespace AppStoreConnect.Uploads;

// Exercises the actual generated SDK and journal under Native AOT, with no network or credentials.
internal static class UploaderSelfTest
{
    internal static async Task<int> RunAsync()
    {
        var root = Directory.CreateTempSubdirectory("appstoreconnect-upload-selftest-");
        try
        {
            foreach (var ambiguous in new[] { false, true })
            {
                var file = Path.Combine(root.FullName, ambiguous + ".ipa");
                await File.WriteAllBytesAsync(file, [1, 2, 3, 4]);
                var options = new TestFlightUploadOptions(file, "ios", "123", "456", "1.0", file + ".json", 2);
                var handler = new Fixture(ambiguous);
                using var api = new AppleBuildUploadApiClient(new HttpClient(handler), "offline-test-token");
                using var transfer = new HttpClient(handler, disposeHandler: false);
                if (ambiguous)
                {
                    try
                    {
                        await TestFlightSdkUpload.UploadAsync(options, api, transfer, null, CancellationToken.None);
                        throw new InvalidDataException("Ambiguous commit unexpectedly succeeded.");
                    }
                    catch (ApiException) { }
                }
                var receipt = await TestFlightSdkUpload.UploadAsync(options, api, transfer, null, CancellationToken.None);
                Check(receipt.Accepted && !receipt.CommitPending && receipt.AcknowledgedRanges.Length == 2, "journal acceptance");
                Check(handler.Builds == 1 && handler.Files == 1 && handler.Commits == 1 && handler.Parts == 2, "exactly-once mutations and transfer");
                var accepted = await TestFlightSdkUpload.UploadAsync(options, api, transfer, null, CancellationToken.None);
                Check(accepted.Accepted && !accepted.TransferredThisInvocation && handler.Commits == 1, "accepted journal replay");
            }
            try
            {
                AppleBuildUploadTransfer.Validate([new(1, 4, "PUT", "https://delivery.apple.com/file", [])], 4);
                throw new InvalidDataException("Invalid partition accepted.");
            }
            catch (InvalidDataException error) when (error.Message.Contains("cover", StringComparison.Ordinal)) { }
            Console.WriteLine("Native uploader self-test passed: generated SDK JSON, exactly-once mutations, durable acknowledgements, ambiguous commit readback, accepted replay and partition validation.");
            return 0;
        }
        finally { root.Delete(recursive: true); }
    }

    private static void Check(bool value, string name)
    {
        if (!value) throw new InvalidDataException("Offline contract failed: " + name);
    }

    private sealed class Fixture(bool ambiguous) : HttpMessageHandler
    {
        internal int Builds, Files, Commits, Parts;
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var uri = request.RequestUri ?? throw new InvalidDataException("Missing URI.");
            if (uri.Host == "delivery.apple.com")
            {
                Check(request.Headers.Authorization is null, "no credential on signed data plane");
                var bytes = await (request.Content ?? throw new InvalidDataException("Missing bytes.")).ReadAsByteArrayAsync(cancellationToken);
                Check(bytes.SequenceEqual(uri.AbsolutePath == "/1" ? new byte[] { 1, 2 } : new byte[] { 3, 4 }), "exact range bytes");
                Interlocked.Increment(ref Parts);
                return new(HttpStatusCode.OK);
            }
            Check(uri.Host == "api.appstoreconnect.apple.com" && request.Headers.Authorization?.Parameter == "offline-test-token", "scoped SDK authentication");
            if (request.Method == HttpMethod.Post)
            {
                using var document = JsonDocument.Parse(await (request.Content ?? throw new InvalidDataException("Missing request.")).ReadAsStringAsync(cancellationToken));
                var data = document.RootElement.GetProperty("data");
                if (uri.AbsolutePath == "/v1/buildUploads")
                {
                    Builds++;
                    Check(data.GetProperty("type").GetString() == "buildUploads" && data.GetProperty("attributes").GetProperty("platform").GetString() == "IOS", "build request JSON");
                    return Json("{\"data\":{\"id\":\"build\",\"type\":\"buildUploads\"}}");
                }
                Files++;
                Check(data.GetProperty("attributes").GetProperty("uti").GetString() == "com.apple.ipa", "file request JSON");
            }
            if (request.Method == HttpMethod.Patch)
            {
                Commits++;
                using var document = JsonDocument.Parse(await (request.Content ?? throw new InvalidDataException("Missing commit.")).ReadAsStringAsync(cancellationToken));
                Check(document.RootElement.GetProperty("data").GetProperty("attributes").GetProperty("uploaded").GetBoolean(), "commit request JSON");
                if (ambiguous) return new(HttpStatusCode.ServiceUnavailable) { Content = new StringContent("{\"errors\":[]}") };
            }
            var state = request.Method == HttpMethod.Post ? "AWAITING_UPLOAD" : "COMPLETE";
            return Json("{\"data\":{\"id\":\"file\",\"type\":\"buildUploadFiles\",\"attributes\":{\"assetDeliveryState\":{\"state\":\"" + state + "\"},\"uploadOperations\":[{\"offset\":0,\"length\":2,\"method\":\"PUT\",\"url\":\"https://delivery.apple.com/1\"},{\"offset\":2,\"length\":2,\"method\":\"PUT\",\"url\":\"https://delivery.apple.com/2\"}]}}}");
        }
        private static HttpResponseMessage Json(string value) => new(HttpStatusCode.OK) { Content = new StringContent(value[..^1] + ",\"links\":{\"self\":\"https://api.appstoreconnect.apple.com/v1/fixture\"}}", Encoding.UTF8, "application/json") };
    }
}
