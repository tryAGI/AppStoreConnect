
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}