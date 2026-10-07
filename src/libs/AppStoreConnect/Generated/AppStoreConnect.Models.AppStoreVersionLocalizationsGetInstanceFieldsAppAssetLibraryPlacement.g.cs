
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppStoreVersionLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}