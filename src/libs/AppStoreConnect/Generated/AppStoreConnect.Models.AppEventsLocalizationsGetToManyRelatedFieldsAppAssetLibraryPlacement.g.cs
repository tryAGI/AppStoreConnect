
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement
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
    public static class AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppEventsLocalizationsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}