#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseImagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseImageV2Response> InAppPurchaseImagesV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseImageV2Response>> InAppPurchaseImagesV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}