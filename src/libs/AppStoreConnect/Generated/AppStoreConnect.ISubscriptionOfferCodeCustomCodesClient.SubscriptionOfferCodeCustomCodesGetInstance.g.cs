#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionOfferCodeCustomCodesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionOfferCodeCustomCodeResponse> SubscriptionOfferCodeCustomCodesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionOfferCodeCustomCodeResponse>> SubscriptionOfferCodeCustomCodesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}