#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasePriceSchedulesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsInAppPurchasePrices"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchasePricesResponse> InAppPurchasePriceSchedulesManualPricesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice>? fieldsInAppPurchasePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsInAppPurchasePrices"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchasePricesResponse>> InAppPurchasePriceSchedulesManualPricesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePrice>? fieldsInAppPurchasePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesManualPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}