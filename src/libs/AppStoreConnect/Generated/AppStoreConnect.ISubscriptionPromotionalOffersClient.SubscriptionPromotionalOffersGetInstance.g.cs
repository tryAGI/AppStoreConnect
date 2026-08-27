#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionPromotionalOffersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionPromotionalOffers"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionPromotionalOfferPrices"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPromotionalOfferResponse> SubscriptionPromotionalOffersGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice>? fieldsSubscriptionPromotionalOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionPromotionalOffers"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionPromotionalOfferPrices"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionPromotionalOfferResponse>> SubscriptionPromotionalOffersGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice>? fieldsSubscriptionPromotionalOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersGetInstanceIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}