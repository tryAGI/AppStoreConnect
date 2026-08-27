#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasesClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseContentResponse> InAppPurchasesV2ContentGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ContentGetToOneRelatedIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseContentResponse>> InAppPurchasesV2ContentGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ContentGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}