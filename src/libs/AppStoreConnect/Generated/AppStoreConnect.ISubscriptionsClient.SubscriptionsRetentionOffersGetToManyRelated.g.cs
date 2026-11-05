#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionOffers"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsRetentionOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RetentionOffersResponse> SubscriptionsRetentionOffersGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer>? fieldsRetentionOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice>? fieldsRetentionOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionOffers"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsRetentionOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RetentionOffersResponse>> SubscriptionsRetentionOffersGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOffer>? fieldsRetentionOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice>? fieldsRetentionOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionOffersGetToManyRelatedIncludeItem>? include = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}