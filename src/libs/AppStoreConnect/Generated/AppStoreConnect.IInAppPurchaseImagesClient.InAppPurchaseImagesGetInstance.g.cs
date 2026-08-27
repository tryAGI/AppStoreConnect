#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseImagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseImageResponse> InAppPurchaseImagesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseImageResponse>> InAppPurchaseImagesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseImagesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}