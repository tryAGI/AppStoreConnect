// MIT. Upload journal/data-plane implementation ported from HavenDV/Advantage.
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AppStoreConnect.Uploads;

[JsonSerializable(typeof(TestFlightUploadReceipt))]
[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true)]
internal partial class TestFlightUploadJsonContext : JsonSerializerContext { }

internal sealed record TestFlightUploadOptions(string File, string Platform, string AppId, string BuildNumber,
    string ShortVersion, string StatePath, int Parallelism = 6, string? ExpectedHost = null);

internal sealed class TestFlightUploadReceipt
{
    public int SchemaVersion { get; set; } = 1;
    public string Transport { get; set; } = "app-store-connect-sdk";
    public string Status { get; set; } = "created";
    public string? FailureCode { get; set; }
    public string Sha256 { get; set; } = "";
    public long ArtifactBytes { get; set; }
    public string AppId { get; set; } = "";
    public string Platform { get; set; } = "";
    public string BuildNumber { get; set; } = "";
    public string ShortVersion { get; set; } = "";
    public string? BuildUploadId { get; set; }
    public string? BuildUploadFileId { get; set; }
    public string? PendingRequest { get; set; }
    public bool CommitPending { get; set; }
    public bool Accepted { get; set; }
    public bool TransferredThisInvocation { get; set; }
    public AppleBuildUploadTransfer.Checkpoint[] AcknowledgedRanges { get; set; } = [];
    public long ResumedBytes { get; set; }
    public string[] AssignedHosts { get; set; } = [];
    public int OperationCount { get; set; }
    public string? GithubRunId { get; set; }
    public string? GithubRunAttempt { get; set; }
    public DateTimeOffset StartedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? CompletedAt { get; set; }
    public double? HashSeconds { get; set; }
    public double? ReserveSeconds { get; set; }
    public double? CommitSeconds { get; set; }
    public double WholeUploaderSeconds { get; set; }
    public int Parallelism { get; set; }
    public AppleBuildUploadTransfer.Result? Transfer { get; set; }
}

/// <summary>Public SDK control plane plus shared streaming data plane; never runs signing or changes a package.</summary>
internal static class TestFlightSdkUpload
{
    internal static readonly JsonSerializerOptions Json = new(JsonSerializerDefaults.Web) { WriteIndented = true };

    internal static void Validate(TestFlightUploadOptions options)
    {
        if (options.Platform is not ("ios" or "macos") || options.AppId.Length == 0 || !options.AppId.All(char.IsAsciiDigit)
            || options.BuildNumber.Length == 0 || !options.BuildNumber.All(c => char.IsAsciiDigit(c) || c == '.')
            || options.ShortVersion.Length == 0 || !options.ShortVersion.All(c => char.IsAsciiDigit(c) || c == '.')
            || options.Parallelism is < 1 or > AppleBuildUploadTransfer.MaxParallelism || string.IsNullOrWhiteSpace(options.StatePath))
            throw new ArgumentException("Valid platform, app ID, numeric build/version, state path and 1..32 parallel operations are required.");
        var suffix = options.Platform == "ios" ? ".ipa" : ".pkg";
        if (!options.File.EndsWith(suffix, StringComparison.OrdinalIgnoreCase) || !System.IO.File.Exists(options.File))
            throw new ArgumentException($"An existing signed {suffix} is required.");
        if (Path.GetFullPath(options.File) == Path.GetFullPath(options.StatePath))
            throw new ArgumentException("The journal must not overwrite the signed package.");
    }

    internal static async Task<TestFlightUploadReceipt> UploadAsync(TestFlightUploadOptions options,
        AppleBuildUploadApiClient api, HttpClient transferClient, Action<AppleBuildUploadTransfer.Part>? progress, CancellationToken ct)
    {
        Validate(options);
        var statePath = Path.GetFullPath(options.StatePath);
        Directory.CreateDirectory(Path.GetDirectoryName(statePath) ?? throw new InvalidDataException("Journal directory is missing."));
        using var lease = new FileStream(statePath + ".lock", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        var clock = Stopwatch.StartNew();
        await using var input = new FileStream(options.File, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, FileOptions.Asynchronous);
        var sha = Convert.ToHexStringLower(await SHA256.HashDataAsync(input, ct).ConfigureAwait(false));
        var receipt = System.IO.File.Exists(statePath)
            ? JsonSerializer.Deserialize(await System.IO.File.ReadAllTextAsync(statePath, ct).ConfigureAwait(false), TestFlightUploadJsonContext.Default.TestFlightUploadReceipt)
                ?? throw new InvalidDataException("Upload journal is empty.")
            : new TestFlightUploadReceipt
            {
                Sha256 = sha, ArtifactBytes = input.Length, AppId = options.AppId, Platform = options.Platform,
                BuildNumber = options.BuildNumber, ShortVersion = options.ShortVersion,
                GithubRunId = Environment.GetEnvironmentVariable("GITHUB_RUN_ID"),
                GithubRunAttempt = Environment.GetEnvironmentVariable("GITHUB_RUN_ATTEMPT"),
            };
        if (receipt.SchemaVersion != 1 || receipt.Sha256 != sha || receipt.ArtifactBytes != input.Length
            || receipt.AppId != options.AppId || receipt.Platform != options.Platform
            || receipt.BuildNumber != options.BuildNumber || receipt.ShortVersion != options.ShortVersion)
            throw new InvalidDataException("Upload journal identity does not match the signed package and metadata.");
        receipt.TransferredThisInvocation = false;
        if (receipt.Accepted)
        {
            receipt.WholeUploaderSeconds = clock.Elapsed.TotalSeconds;
            Save(statePath, receipt);
            return receipt;
        }
        if (receipt.PendingRequest is not null)
            throw new InvalidOperationException("A previous Apple reservation has an unknown outcome. Reconcile it before retrying; do not switch uploaders.");
        receipt.HashSeconds = clock.Elapsed.TotalSeconds;
        receipt.Parallelism = options.Parallelism;
        Save(statePath, receipt);
        Stopwatch? reservationClock = null;
        Stopwatch? commitClock = null;
        try
        {
            if (receipt.CommitPending)
            {
                var observed = await api.ReadFileAsync(receipt.BuildUploadFileId ?? throw new InvalidDataException("Upload file identity is missing."), ct).ConfigureAwait(false);
                var state = observed.Data.Attributes?.AssetDeliveryState?.State;
                if (state != AppMediaAssetStateState.Complete)
                    throw new InvalidOperationException("Apple commit is not confirmed. Keep the same journal and inspect Apple state; no second upload was started.");
                receipt.Accepted = true;
            }
            else
            {
                reservationClock = Stopwatch.StartNew();
                if (receipt.BuildUploadId is null)
                {
                    receipt.PendingRequest = "create-build-upload";
                    Save(statePath, receipt);
                    var created = await api.CreateBuildAsync(new BuildUploadCreateRequestData
                    {
                        Attributes = new BuildUploadCreateRequestDataAttributes
                        {
                            CfBundleVersion = options.BuildNumber, CfBundleShortVersionString = options.ShortVersion,
                            Platform = options.Platform == "ios" ? Platform.Ios : Platform.MacOs,
                        },
                        Relationships = new BuildUploadCreateRequestDataRelationships
                        {
                            App = new BuildUploadCreateRequestDataRelationshipsApp
                            { Data = new BuildUploadCreateRequestDataRelationshipsAppData { Id = options.AppId } },
                        },
                    }, ct).ConfigureAwait(false);
                    receipt.BuildUploadId = created.Data.Id;
                    receipt.PendingRequest = null;
                    Save(statePath, receipt);
                }
                BuildUploadFileResponse file;
                if (receipt.BuildUploadFileId is null)
                {
                    receipt.PendingRequest = "create-build-upload-file";
                    Save(statePath, receipt);
                    file = await api.CreateFileAsync(new BuildUploadFileCreateRequestData
                    {
                        Attributes = new BuildUploadFileCreateRequestDataAttributes
                        {
                            FileName = Path.GetFileName(options.File), FileSize = input.Length,
                            Uti = options.Platform == "ios" ? BuildUploadFileCreateRequestDataAttributesUti.ComAppleIpa : BuildUploadFileCreateRequestDataAttributesUti.ComApplePkg,
                            AssetType = BuildUploadFileCreateRequestDataAttributesAssetType.Asset,
                        },
                        Relationships = new BuildUploadFileCreateRequestDataRelationships
                        {
                            BuildUpload = new BuildUploadFileCreateRequestDataRelationshipsBuildUpload
                            { Data = new BuildUploadFileCreateRequestDataRelationshipsBuildUploadData { Id = receipt.BuildUploadId } },
                        },
                    }, ct).ConfigureAwait(false);
                    receipt.BuildUploadFileId = file.Data.Id;
                    receipt.PendingRequest = null;
                    Save(statePath, receipt);
                }
                else file = await api.ReadFileAsync(receipt.BuildUploadFileId, ct).ConfigureAwait(false);
                receipt.ReserveSeconds = reservationClock.Elapsed.TotalSeconds;
                reservationClock = null;
                var operations = (file.Data.Attributes?.UploadOperations ?? []).Select(Map).OrderBy(x => x.Offset).ToArray();
                AppleBuildUploadTransfer.Validate(operations, input.Length, options.ExpectedHost);
                receipt.AssignedHosts = operations.Select(x => new Uri(x.Url).IdnHost).Distinct().ToArray();
                receipt.OperationCount = operations.Length;
                receipt.Status = "transferring";
                Save(statePath, receipt);
                receipt.ResumedBytes = receipt.AcknowledgedRanges.Sum(range => range.Length);
                var checkpointLock = new object();
                receipt.Transfer = await AppleBuildUploadTransfer.UploadAsync(transferClient, options.File, input.Length,
                    operations, options.Parallelism, part =>
                    {
                        lock (checkpointLock)
                        {
                            var operation = operations[part.Number - 1];
                            receipt.AcknowledgedRanges = [.. receipt.AcknowledgedRanges,
                                new AppleBuildUploadTransfer.Checkpoint(operation.Offset, operation.Length)];
                            Save(statePath, receipt);
                            progress?.Invoke(part);
                        }
                    }, ct, options.ExpectedHost, capturedInput: input, acknowledged: receipt.AcknowledgedRanges).ConfigureAwait(false);
                receipt.TransferredThisInvocation = receipt.Transfer.Bytes > 0;
                // A changed local file must never be committed after its byte ranges have been sent.
                input.Position = 0;
                if (Convert.ToHexStringLower(await SHA256.HashDataAsync(input, ct).ConfigureAwait(false)) != sha)
                    throw new InvalidDataException("Signed package changed during upload. Apple reservation was not committed.");
                receipt.CommitPending = true;
                receipt.Status = "committing";
                Save(statePath, receipt);
                commitClock = Stopwatch.StartNew();
                var committedFile = await api.CommitFileAsync(receipt.BuildUploadFileId,
                    new BuildUploadFileUpdateRequestData
                    {
                        Id = receipt.BuildUploadFileId,
                        Attributes = new BuildUploadFileUpdateRequestDataAttributes { Uploaded = true },
                    }, ct).ConfigureAwait(false);
                receipt.CommitSeconds = commitClock.Elapsed.TotalSeconds;
                commitClock = null;
                if (committedFile.Data.Attributes?.AssetDeliveryState?.State != AppMediaAssetStateState.Complete)
                    throw new InvalidDataException("Apple did not confirm a COMPLETE upload file; keep the journal for reconciliation.");
                receipt.Accepted = true;
            }
            receipt.Status = "accepted";
            receipt.CommitPending = false;
            receipt.FailureCode = null;
            receipt.CompletedAt = DateTimeOffset.UtcNow;
            return receipt;
        }
        catch (Exception ex)
        {
            receipt.Status = ct.IsCancellationRequested ? "cancelled" : receipt.CommitPending ? "commit_unknown" : "failed";
            // API responses and exception messages can contain signed URLs; retain only safe categories.
            receipt.FailureCode = ex is ApiException apiError ? $"apple-http-{(int)apiError.StatusCode}" : ex.GetType().Name;
            throw;
        }
        finally
        {
            // Failed control-plane requests still consumed measurable time. Phases that
            // never started stay null instead of masquerading as zero-cost work.
            if (reservationClock is not null) receipt.ReserveSeconds = reservationClock.Elapsed.TotalSeconds;
            if (commitClock is not null) receipt.CommitSeconds = commitClock.Elapsed.TotalSeconds;
            receipt.WholeUploaderSeconds = clock.Elapsed.TotalSeconds;
            Save(statePath, receipt);
        }
    }

    internal static AppleBuildUploadTransfer.Operation Map(DeliveryFileUploadOperation operation) => new(
        operation.Offset ?? throw new InvalidDataException("Missing upload offset."),
        operation.Length ?? throw new InvalidDataException("Missing upload length."), operation.Method ?? "PUT",
        operation.Url ?? throw new InvalidDataException("Missing upload URL."),
        (operation.RequestHeaders ?? []).Select(x => new AppleBuildUploadTransfer.Header(x.Name ?? "", x.Value ?? "")).ToArray());

    internal static void Save(string path, TestFlightUploadReceipt receipt)
    {
        var temporary = path + $".{Environment.ProcessId}.tmp";
        try
        {
            using (var stream = new FileStream(temporary, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                if (!OperatingSystem.IsWindows()) System.IO.File.SetUnixFileMode(temporary, UnixFileMode.UserRead | UnixFileMode.UserWrite);
                JsonSerializer.Serialize(stream, receipt, TestFlightUploadJsonContext.Default.TestFlightUploadReceipt);
                stream.Flush(flushToDisk: true);
            }
            System.IO.File.Move(temporary, path, overwrite: true);
        }
        finally { System.IO.File.Delete(temporary); }
    }
}
