
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppCustomProductPageLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}