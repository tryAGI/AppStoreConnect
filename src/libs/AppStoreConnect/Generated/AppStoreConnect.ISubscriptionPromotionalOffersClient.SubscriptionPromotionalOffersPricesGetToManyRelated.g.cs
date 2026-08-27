#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionPromotionalOffersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionPromotionalOfferPrices"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponse> SubscriptionPromotionalOffersPricesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>? fieldsSubscriptionPromotionalOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionPromotionalOfferPrices"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponse>> SubscriptionPromotionalOffersPricesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>? fieldsSubscriptionPromotionalOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}