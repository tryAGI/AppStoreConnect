#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppPricePointsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppPricePoints"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPricePointV3Response> AppPricePointsV3GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceFieldsAppPricePoint>? fieldsAppPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppPricePoints"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPricePointV3Response>> AppPricePointsV3GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceFieldsAppPricePoint>? fieldsAppPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPricePointsV3GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}