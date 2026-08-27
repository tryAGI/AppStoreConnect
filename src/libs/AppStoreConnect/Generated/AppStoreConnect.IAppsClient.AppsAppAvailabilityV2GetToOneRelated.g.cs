#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAvailabilityV2Response> AppsAppAvailabilityV2GetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie>? fieldsAppAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie>? fieldsTerritoryAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppAvailabilityV2GetToOneRelatedIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAvailabilityV2Response>> AppsAppAvailabilityV2GetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie>? fieldsAppAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppAvailabilityV2GetToOneRelatedFieldsTerritoryAvailabilitie>? fieldsTerritoryAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppAvailabilityV2GetToOneRelatedIncludeItem>? include = default,
            int? limitTerritoryAvailabilities = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}