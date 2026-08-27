#nullable enable

namespace AppStoreConnect
{
    public partial interface IRoutingAppCoveragesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRoutingAppCoverages"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RoutingAppCoverageResponse> RoutingAppCoveragesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RoutingAppCoveragesGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RoutingAppCoveragesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRoutingAppCoverages"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RoutingAppCoverageResponse>> RoutingAppCoveragesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RoutingAppCoveragesGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RoutingAppCoveragesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}