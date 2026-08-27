#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionPromotionalOffers"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionPromotionalOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPromotionalOffersResponse> SubscriptionsPromotionalOffersGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>? fieldsSubscriptionPromotionalOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionPromotionalOffers"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionPromotionalOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionPromotionalOffersResponse>> SubscriptionsPromotionalOffersGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>? fieldsSubscriptionPromotionalOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsPromotionalOffersGetToManyRelatedIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}