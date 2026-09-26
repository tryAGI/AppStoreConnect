#nullable enable

namespace AppStoreConnect
{
    public partial interface IAlternativeDistributionKeysClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="existsApp"></param>
        /// <param name="fieldsAlternativeDistributionKeys"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AlternativeDistributionKeysResponse> AlternativeDistributionKeysGetCollectionAsync(
            bool? existsApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionKeysGetCollectionFieldsAlternativeDistributionKey>? fieldsAlternativeDistributionKeys = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="existsApp"></param>
        /// <param name="fieldsAlternativeDistributionKeys"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AlternativeDistributionKeysResponse>> AlternativeDistributionKeysGetCollectionAsResponseAsync(
            bool? existsApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionKeysGetCollectionFieldsAlternativeDistributionKey>? fieldsAlternativeDistributionKeys = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AlternativeDistributionKeysGetCollectionAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.AlternativeDistributionKey&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="existsApp"></param>
        /// <param name="fieldsAlternativeDistributionKeys"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.AlternativeDistributionKey> AlternativeDistributionKeysGetCollectionAutoPagingAsync(
              bool? existsApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionKeysGetCollectionFieldsAlternativeDistributionKey>? fieldsAlternativeDistributionKeys = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}