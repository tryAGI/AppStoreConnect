
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}