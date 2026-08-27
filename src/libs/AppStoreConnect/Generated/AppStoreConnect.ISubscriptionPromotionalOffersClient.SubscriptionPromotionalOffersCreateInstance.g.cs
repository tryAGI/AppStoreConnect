#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionPromotionalOffersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPromotionalOfferResponse> SubscriptionPromotionalOffersCreateInstanceAsync(

            global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionPromotionalOfferResponse>> SubscriptionPromotionalOffersCreateInstanceAsResponseAsync(

            global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="included"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPromotionalOfferResponse> SubscriptionPromotionalOffersCreateInstanceAsync(
            global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreate>? included = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}