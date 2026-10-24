namespace AppStoreConnect.Uploads;

// Use only the two scoped generated clients: no all-API client, reflection or handwritten REST DTOs.
internal sealed class AppleBuildUploadApiClient(HttpClient client, string token) : IDisposable
{
    private readonly BuildUploadsClient builds = new(token, client, disposeHttpClient: false);
    private readonly BuildUploadFilesClient files = new(token, client, disposeHttpClient: false);

    private static readonly AutoSDKRequestOptions Mutation = new() { Retry = new AutoSDKRetryOptions { MaxAttempts = 1 } };
    internal static AppleBuildUploadApiClient Create(string issuer, string keyId, string pem)
    {
        var token = new AppStoreConnectCredential(issuer, keyId, pem).CreateToken(DateTimeOffset.UtcNow);
        var client = new HttpClient(new SocketsHttpHandler { AllowAutoRedirect = false });
        try { return new(client, token); }
        catch { client.Dispose(); throw; }
    }

    internal Task<BuildUploadResponse> CreateBuildAsync(BuildUploadCreateRequestData data, CancellationToken ct) =>
        builds.BuildUploadsCreateInstanceAsync(new BuildUploadCreateRequest { Data = data }, requestOptions: Mutation, cancellationToken: ct);
    internal Task<BuildUploadFileResponse> CreateFileAsync(BuildUploadFileCreateRequestData data, CancellationToken ct) =>
        files.BuildUploadFilesCreateInstanceAsync(new BuildUploadFileCreateRequest { Data = data }, requestOptions: Mutation, cancellationToken: ct);
    internal Task<BuildUploadFileResponse> ReadFileAsync(string id, CancellationToken ct) =>
        files.BuildUploadFilesGetInstanceAsync(id, cancellationToken: ct);
    internal Task<BuildUploadFileResponse> CommitFileAsync(string id, BuildUploadFileUpdateRequestData data, CancellationToken ct) =>
        files.BuildUploadFilesUpdateInstanceAsync(id, new BuildUploadFileUpdateRequest { Data = data }, requestOptions: Mutation, cancellationToken: ct);

    public void Dispose()
    {
        builds.Dispose();
        files.Dispose();
        client.Dispose();
    }
}
