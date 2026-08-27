#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionsClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RoutingAppCoverageResponse> AppStoreVersionsRoutingAppCoverageGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RoutingAppCoverageResponse>> AppStoreVersionsRoutingAppCoverageGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}