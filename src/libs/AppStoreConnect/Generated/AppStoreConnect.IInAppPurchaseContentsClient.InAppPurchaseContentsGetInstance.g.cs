#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseContentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseContents"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseContentResponse> InAppPurchaseContentsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseContentsGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseContentsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseContents"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseContentResponse>> InAppPurchaseContentsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseContentsGetInstanceFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseContentsGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseContentsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}