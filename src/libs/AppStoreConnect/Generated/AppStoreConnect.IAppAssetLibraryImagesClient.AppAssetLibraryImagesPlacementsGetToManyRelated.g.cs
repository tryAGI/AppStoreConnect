#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAssetLibraryImagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlacementType"></param>
        /// <param name="filterPlacementGroup"></param>
        /// <param name="filterState"></param>
        /// <param name="filterVideo"></param>
        /// <param name="filterAppEventLocalization"></param>
        /// <param name="filterAppStoreVersionLocalization"></param>
        /// <param name="filterAppCustomProductPageLocalization"></param>
        /// <param name="filterAppStoreVersionExperimentTreatmentLocalization"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryVideos"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryPlacementsResponse> AppAssetLibraryImagesPlacementsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem>? filterPlacementType = default,
            global::System.Collections.Generic.IList<string>? filterPlacementGroup = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterVideo = default,
            global::System.Collections.Generic.IList<string>? filterAppEventLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppCustomProductPageLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>? fieldsAppAssetLibraryVideos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlacementType"></param>
        /// <param name="filterPlacementGroup"></param>
        /// <param name="filterState"></param>
        /// <param name="filterVideo"></param>
        /// <param name="filterAppEventLocalization"></param>
        /// <param name="filterAppStoreVersionLocalization"></param>
        /// <param name="filterAppCustomProductPageLocalization"></param>
        /// <param name="filterAppStoreVersionExperimentTreatmentLocalization"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryVideos"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAssetLibraryPlacementsResponse>> AppAssetLibraryImagesPlacementsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterPlacementTypeItem>? filterPlacementType = default,
            global::System.Collections.Generic.IList<string>? filterPlacementGroup = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterVideo = default,
            global::System.Collections.Generic.IList<string>? filterAppEventLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppCustomProductPageLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo>? fieldsAppAssetLibraryVideos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}