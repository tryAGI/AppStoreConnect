
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}