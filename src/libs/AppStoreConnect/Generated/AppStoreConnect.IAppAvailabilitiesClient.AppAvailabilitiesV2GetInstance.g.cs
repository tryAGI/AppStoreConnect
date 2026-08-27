#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAvailabilitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppAvailabilities"></param>
        /// <param name="fieldsTerritoryAvailabilities"></param>
        /// <param name="include"></param>
        /// <param name="limitTerritoryAvailabilities"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAvailabilityV2Response> AppAvailabilitiesV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie>? fieldsAppAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie>? fieldsTerritoryAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2GetInstanceIncludeItem>? include = default,
            int? limitTerritoryAvailabilities = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppAvailabilities"></param>
        /// <param name="fieldsTerritoryAvailabilities"></param>
        /// <param name="include"></param>
        /// <param name="limitTerritoryAvailabilities"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAvailabilityV2Response>> AppAvailabilitiesV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie>? fieldsAppAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsTerritoryAvailabilitie>? fieldsTerritoryAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2GetInstanceIncludeItem>? include = default,
            int? limitTerritoryAvailabilities = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}