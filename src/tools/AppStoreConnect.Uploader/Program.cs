using System.Globalization;
using System.Text.Json;
using AppStoreConnect.Uploads;

return await UploaderProgram.RunAsync(args);

internal static class UploaderProgram
{
    internal static async Task<int> RunAsync(string[] arguments)
    {
        if (arguments.SequenceEqual(new[] { "self-test" })) return await UploaderSelfTest.RunAsync();
        if (arguments.Length == 0 || arguments.Contains("--help", StringComparer.Ordinal))
        {
            Console.WriteLine("appstoreconnect-upload upload --file signed.ipa --platform ios --app-id ID --build-number N --short-version V --state journal.json --private-key-path key.p8 [--parallelism 12]");
            Console.WriteLine("Uses APP_STORE_CONNECT_KEY_ID and APP_STORE_CONNECT_ISSUER_ID. A retry must reuse the same journal. No signing, backend relay, or processing/distribution changes.");
            return 0;
        }
        using var cancellation = new CancellationTokenSource(TimeSpan.FromMinutes(15));
        ConsoleCancelEventHandler cancel = (_, e) => { e.Cancel = true; cancellation.Cancel(); };
        Console.CancelKeyPress += cancel;
        try
        {
            var values = Parse(arguments);
            string Required(string name) => values.TryGetValue(name, out var value) && !string.IsNullOrWhiteSpace(value)
                ? value : throw new ArgumentException("Missing " + name);
            string Credential(string name, string environment) => values.GetValueOrDefault(name)
                ?? Environment.GetEnvironmentVariable(environment) ?? throw new ArgumentException("Missing " + name);
            var options = new TestFlightUploadOptions(Required("--file"), Required("--platform"), Required("--app-id"),
                Required("--build-number"), values.GetValueOrDefault("--short-version", "1.0"), Required("--state"),
                int.Parse(values.GetValueOrDefault("--parallelism", "12"), CultureInfo.InvariantCulture), values.GetValueOrDefault("--expected-host"));
            TestFlightSdkUpload.Validate(options);
            var pem = await File.ReadAllTextAsync(Credential("--private-key-path", "API_KEY_PATH"), cancellation.Token);
            using var api = AppleBuildUploadApiClient.Create(Credential("--issuer-id", "APP_STORE_CONNECT_ISSUER_ID"),
                Credential("--key-id", "APP_STORE_CONNECT_KEY_ID"), pem);
            using var transfer = AppleBuildUploadTransfer.CreateClient(options.Parallelism);
            var receipt = await TestFlightSdkUpload.UploadAsync(options, api, transfer, part =>
                Console.Error.WriteLine($"Apple upload: part {part.Number}; bytes={part.Bytes}; attempts={part.Attempts}"), cancellation.Token);
            Console.WriteLine(JsonSerializer.Serialize(receipt, TestFlightUploadJsonContext.Default.TestFlightUploadReceipt));
            Console.WriteLine("UPLOAD SUCCEEDED via App Store Connect SDK; processing/distribution require separate verification.");
            return 0;
        }
        catch (Exception error)
        {
            // API exception bodies can contain signed URLs: print only a safe category.
            var code = error is AppStoreConnect.ApiException api ? $"apple-http-{(int)api.StatusCode}" : error.GetType().Name;
            Console.Error.WriteLine($"Upload failed: {code}. Preserve the journal and reconcile unknown Apple outcomes before retrying.");
            return cancellation.IsCancellationRequested ? 130 : 1;
        }
        finally { Console.CancelKeyPress -= cancel; }
    }

    internal static Dictionary<string, string> Parse(string[] arguments)
    {
        var offset = arguments[0] == "testflight" && arguments.Length > 1 && arguments[1] == "upload" ? 2
            : arguments[0] == "upload" ? 1 : throw new ArgumentException("Expected upload command.");
        string[] allowed = ["--file", "--platform", "--app-id", "--build-number", "--short-version", "--state", "--private-key-path", "--key-id", "--issuer-id", "--parallelism", "--expected-host"];
        var result = new Dictionary<string, string>(StringComparer.Ordinal);
        for (var index = offset; index < arguments.Length; index += 2)
            if (!allowed.Contains(arguments[index], StringComparer.Ordinal) || index + 1 >= arguments.Length
                || !result.TryAdd(arguments[index], arguments[index + 1]))
                throw new ArgumentException("Unknown, duplicate or incomplete upload option.");
        return result;
    }
}
