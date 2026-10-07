
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement
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
    public static class AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}