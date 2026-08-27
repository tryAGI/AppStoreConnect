#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseOfferCodeCustomCodesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeResponse> InAppPurchaseOfferCodeCustomCodesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeResponse>> InAppPurchaseOfferCodeCustomCodesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}