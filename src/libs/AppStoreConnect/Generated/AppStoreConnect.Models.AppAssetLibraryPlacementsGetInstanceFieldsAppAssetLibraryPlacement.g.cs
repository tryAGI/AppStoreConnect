
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}