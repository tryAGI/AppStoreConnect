
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement
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
    public static class AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}