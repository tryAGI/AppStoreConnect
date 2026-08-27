#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseOfferCodesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferPrices"></param>
        /// <param name="include"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseOfferCodeResponse> InAppPurchaseOfferCodesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode>? fieldsInAppPurchaseOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice>? fieldsInAppPurchaseOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceIncludeItem>? include = default,
            int? limitCustomCodes = default,
            int? limitOneTimeUseCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferPrices"></param>
        /// <param name="include"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseOfferCodeResponse>> InAppPurchaseOfferCodesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode>? fieldsInAppPurchaseOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice>? fieldsInAppPurchaseOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesGetInstanceIncludeItem>? include = default,
            int? limitCustomCodes = default,
            int? limitOneTimeUseCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}