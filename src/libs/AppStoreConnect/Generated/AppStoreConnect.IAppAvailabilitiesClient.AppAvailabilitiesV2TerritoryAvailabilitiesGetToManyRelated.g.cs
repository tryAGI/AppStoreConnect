#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAvailabilitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsTerritoryAvailabilities"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.TerritoryAvailabilitiesResponse> AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie>? fieldsTerritoryAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsTerritoryAvailabilities"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.TerritoryAvailabilitiesResponse>> AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritoryAvailabilitie>? fieldsTerritoryAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}