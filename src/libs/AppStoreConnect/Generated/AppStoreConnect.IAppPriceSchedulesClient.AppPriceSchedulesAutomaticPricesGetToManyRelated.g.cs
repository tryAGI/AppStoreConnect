#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppPriceSchedulesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterStartDate"></param>
        /// <param name="filterEndDate"></param>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsAppPrices"></param>
        /// <param name="fieldsAppPricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPricesV2Response> AppPriceSchedulesAutomaticPricesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterStartDate = default,
            global::System.Collections.Generic.IList<string>? filterEndDate = default,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice>? fieldsAppPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint>? fieldsAppPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterStartDate"></param>
        /// <param name="filterEndDate"></param>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsAppPrices"></param>
        /// <param name="fieldsAppPricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPricesV2Response>> AppPriceSchedulesAutomaticPricesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterStartDate = default,
            global::System.Collections.Generic.IList<string>? filterEndDate = default,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice>? fieldsAppPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint>? fieldsAppPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}