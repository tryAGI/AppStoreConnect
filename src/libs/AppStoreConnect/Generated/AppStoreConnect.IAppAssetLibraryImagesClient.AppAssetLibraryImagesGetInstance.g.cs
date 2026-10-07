#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAssetLibraryImagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="include"></param>
        /// <param name="limitPlacements"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryImageResponse> AppAssetLibraryImagesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesGetInstanceIncludeItem>? include = default,
            int? limitPlacements = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="include"></param>
        /// <param name="limitPlacements"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAssetLibraryImageResponse>> AppAssetLibraryImagesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesGetInstanceIncludeItem>? include = default,
            int? limitPlacements = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}