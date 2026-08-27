#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseAppStoreReviewScreenshots"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotResponse> InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot>? fieldsInAppPurchaseAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseAppStoreReviewScreenshots"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotResponse>> InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot>? fieldsInAppPurchaseAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}