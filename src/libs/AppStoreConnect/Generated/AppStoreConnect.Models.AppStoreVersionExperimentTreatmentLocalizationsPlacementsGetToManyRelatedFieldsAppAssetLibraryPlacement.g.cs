
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}