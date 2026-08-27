#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterDeviceFamily"></param>
        /// <param name="filterState"></param>
        /// <param name="fieldsAccessibilityDeclarations"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AccessibilityDeclarationsResponse> AppsAccessibilityDeclarationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem>? filterDeviceFamily = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration>? fieldsAccessibilityDeclarations = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterDeviceFamily"></param>
        /// <param name="filterState"></param>
        /// <param name="fieldsAccessibilityDeclarations"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AccessibilityDeclarationsResponse>> AppsAccessibilityDeclarationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem>? filterDeviceFamily = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAccessibilityDeclarationsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAccessibilityDeclarationsGetToManyRelatedFieldsAccessibilityDeclaration>? fieldsAccessibilityDeclarations = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}