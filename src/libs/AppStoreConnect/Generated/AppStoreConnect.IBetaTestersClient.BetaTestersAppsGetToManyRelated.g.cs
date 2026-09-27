#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaTestersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppsWithoutIncludesResponse> BetaTestersAppsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersAppsGetToManyRelatedFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppsWithoutIncludesResponse>> BetaTestersAppsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersAppsGetToManyRelatedFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaTestersAppsGetToManyRelatedAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.App&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.App> BetaTestersAppsGetToManyRelatedAutoPagingAsync(
            string id,             global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersAppsGetToManyRelatedFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}