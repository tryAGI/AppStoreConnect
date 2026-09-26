#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiProductsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiProductBuildRunsLinkagesResponse> CiProductsBuildRunsGetToManyRelationshipAsync(
            string id,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiProductBuildRunsLinkagesResponse>> CiProductsBuildRunsGetToManyRelationshipAsResponseAsync(
            string id,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps CiProductsBuildRunsGetToManyRelationshipAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem> CiProductsBuildRunsGetToManyRelationshipAutoPagingAsync(
            string id,             int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}