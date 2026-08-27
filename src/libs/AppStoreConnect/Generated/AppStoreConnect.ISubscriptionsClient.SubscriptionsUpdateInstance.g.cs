#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionResponse> SubscriptionsUpdateInstanceAsync(
            string id,

            global::AppStoreConnect.SubscriptionUpdateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionResponse>> SubscriptionsUpdateInstanceAsResponseAsync(
            string id,

            global::AppStoreConnect.SubscriptionUpdateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="included"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionResponse> SubscriptionsUpdateInstanceAsync(
            string id,
            global::AppStoreConnect.SubscriptionUpdateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>>? included = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}