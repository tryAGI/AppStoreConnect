#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionOfferCodesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodePrices"></param>
        /// <param name="include"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionOfferCodeResponse> SubscriptionOfferCodesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode>? fieldsSubscriptionOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice>? fieldsSubscriptionOfferCodePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem>? include = default,
            int? limitCustomCodes = default,
            int? limitOneTimeUseCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodePrices"></param>
        /// <param name="include"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionOfferCodeResponse>> SubscriptionOfferCodesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode>? fieldsSubscriptionOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice>? fieldsSubscriptionOfferCodePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesGetInstanceIncludeItem>? include = default,
            int? limitCustomCodes = default,
            int? limitOneTimeUseCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}