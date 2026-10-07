
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement
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
    public static class AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}