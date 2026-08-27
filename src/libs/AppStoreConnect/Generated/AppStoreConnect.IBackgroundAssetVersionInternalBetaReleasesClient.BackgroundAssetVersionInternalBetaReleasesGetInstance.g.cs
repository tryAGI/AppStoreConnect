#nullable enable

namespace AppStoreConnect
{
    public partial interface IBackgroundAssetVersionInternalBetaReleasesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBackgroundAssetVersionInternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseResponse> BackgroundAssetVersionInternalBetaReleasesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>? fieldsBackgroundAssetVersionInternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBackgroundAssetVersionInternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseResponse>> BackgroundAssetVersionInternalBetaReleasesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>? fieldsBackgroundAssetVersionInternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}