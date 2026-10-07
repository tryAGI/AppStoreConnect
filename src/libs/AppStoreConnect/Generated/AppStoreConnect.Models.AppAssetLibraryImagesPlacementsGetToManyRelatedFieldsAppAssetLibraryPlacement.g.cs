
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalization,
        /// <summary>
        ///
        /// </summary>
        AppEventLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalization,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        LastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        MediaType,
        /// <summary>
        ///
        /// </summary>
        PlacementGroup,
        /// <summary>
        ///
        /// </summary>
        PlacementType,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        StateDetails,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}