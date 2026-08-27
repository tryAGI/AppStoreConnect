#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseLocalizationResponse> InAppPurchaseLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseLocalizationResponse>> InAppPurchaseLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}