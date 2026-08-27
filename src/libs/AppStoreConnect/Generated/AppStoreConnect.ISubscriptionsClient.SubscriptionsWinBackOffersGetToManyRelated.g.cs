#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsWinBackOffers"></param>
        /// <param name="fieldsWinBackOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.WinBackOffersResponse> SubscriptionsWinBackOffersGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice>? fieldsWinBackOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsWinBackOffers"></param>
        /// <param name="fieldsWinBackOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.WinBackOffersResponse>> SubscriptionsWinBackOffersGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice>? fieldsWinBackOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}