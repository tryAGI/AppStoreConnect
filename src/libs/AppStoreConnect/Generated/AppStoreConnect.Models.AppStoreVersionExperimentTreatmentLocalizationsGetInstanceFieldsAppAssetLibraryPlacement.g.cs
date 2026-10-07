
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}