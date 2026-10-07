
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppEventLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}