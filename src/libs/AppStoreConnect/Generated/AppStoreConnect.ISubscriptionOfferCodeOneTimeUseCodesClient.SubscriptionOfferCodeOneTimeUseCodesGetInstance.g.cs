#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionOfferCodeOneTimeUseCodesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeResponse> SubscriptionOfferCodeOneTimeUseCodesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode>? fieldsSubscriptionOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeResponse>> SubscriptionOfferCodeOneTimeUseCodesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode>? fieldsSubscriptionOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}