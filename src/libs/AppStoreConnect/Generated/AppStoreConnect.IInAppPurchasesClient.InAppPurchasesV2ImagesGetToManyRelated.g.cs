#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseImagesResponse> InAppPurchasesV2ImagesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ImagesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseImagesResponse>> InAppPurchasesV2ImagesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2ImagesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}