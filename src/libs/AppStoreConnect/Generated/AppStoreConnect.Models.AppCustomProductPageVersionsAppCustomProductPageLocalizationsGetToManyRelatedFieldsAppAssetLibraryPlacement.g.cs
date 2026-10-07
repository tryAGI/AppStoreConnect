
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement
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
    public static class AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}