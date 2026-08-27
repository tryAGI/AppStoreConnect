#nullable enable

namespace AppStoreConnect
{
    public partial interface IBackgroundAssetVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="fieldsBackgroundAssets"></param>
        /// <param name="fieldsBackgroundAssetVersionInternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionExternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionAppStoreReleases"></param>
        /// <param name="fieldsBackgroundAssetUploadFiles"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BackgroundAssetVersionResponse> BackgroundAssetVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset>? fieldsBackgroundAssets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>? fieldsBackgroundAssetVersionInternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease>? fieldsBackgroundAssetVersionExternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease>? fieldsBackgroundAssetVersionAppStoreReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile>? fieldsBackgroundAssetUploadFiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="fieldsBackgroundAssets"></param>
        /// <param name="fieldsBackgroundAssetVersionInternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionExternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionAppStoreReleases"></param>
        /// <param name="fieldsBackgroundAssetUploadFiles"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BackgroundAssetVersionResponse>> BackgroundAssetVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset>? fieldsBackgroundAssets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>? fieldsBackgroundAssetVersionInternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease>? fieldsBackgroundAssetVersionExternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease>? fieldsBackgroundAssetVersionAppStoreReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile>? fieldsBackgroundAssetUploadFiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}