#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAssetLibraryPlacementsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryVideos"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryPlacementResponse> AppAssetLibraryPlacementsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo>? fieldsAppAssetLibraryVideos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryVideos"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAssetLibraryPlacementResponse>> AppAssetLibraryPlacementsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo>? fieldsAppAssetLibraryVideos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}