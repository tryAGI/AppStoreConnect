#nullable enable

namespace AppStoreConnect
{
    public partial interface ISandboxTestersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSandboxTesters"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SandboxTestersV2Response> SandboxTestersV2GetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.SandboxTestersV2GetCollectionFieldsSandboxTester>? fieldsSandboxTesters = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSandboxTesters"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SandboxTestersV2Response>> SandboxTestersV2GetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.SandboxTestersV2GetCollectionFieldsSandboxTester>? fieldsSandboxTesters = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}