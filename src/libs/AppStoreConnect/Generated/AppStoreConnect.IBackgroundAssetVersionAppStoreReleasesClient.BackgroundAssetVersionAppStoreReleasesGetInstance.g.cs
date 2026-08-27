#nullable enable

namespace AppStoreConnect
{
    public partial interface IBackgroundAssetVersionAppStoreReleasesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBackgroundAssetVersionAppStoreReleases"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseResponse> BackgroundAssetVersionAppStoreReleasesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease>? fieldsBackgroundAssetVersionAppStoreReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBackgroundAssetVersionAppStoreReleases"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseResponse>> BackgroundAssetVersionAppStoreReleasesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease>? fieldsBackgroundAssetVersionAppStoreReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}