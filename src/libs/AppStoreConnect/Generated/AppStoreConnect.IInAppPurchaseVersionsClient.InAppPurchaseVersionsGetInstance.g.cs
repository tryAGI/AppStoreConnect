#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseVersionResponse> InAppPurchaseVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseVersionResponse>> InAppPurchaseVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsGetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}