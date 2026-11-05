#nullable enable

namespace AppStoreConnect
{
    public partial interface IRetentionMessageVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageLocalizations"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RetentionMessageVersionResponse> RetentionMessageVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization>? fieldsRetentionMessageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageLocalizations"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RetentionMessageVersionResponse>> RetentionMessageVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization>? fieldsRetentionMessageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}