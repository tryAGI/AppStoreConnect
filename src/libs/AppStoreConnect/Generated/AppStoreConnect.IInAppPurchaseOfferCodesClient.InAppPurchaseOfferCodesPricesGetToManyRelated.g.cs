#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseOfferCodesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsInAppPurchaseOfferPrices"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseOfferPricesResponse> InAppPurchaseOfferCodesPricesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice>? fieldsInAppPurchaseOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsInAppPurchaseOfferPrices"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseOfferPricesResponse>> InAppPurchaseOfferCodesPricesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice>? fieldsInAppPurchaseOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}