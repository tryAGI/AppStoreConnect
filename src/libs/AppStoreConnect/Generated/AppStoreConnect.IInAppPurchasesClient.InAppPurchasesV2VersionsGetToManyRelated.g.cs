#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseVersionsResponse> InAppPurchasesV2VersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitImages = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseVersionsResponse>> InAppPurchasesV2VersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitImages = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}