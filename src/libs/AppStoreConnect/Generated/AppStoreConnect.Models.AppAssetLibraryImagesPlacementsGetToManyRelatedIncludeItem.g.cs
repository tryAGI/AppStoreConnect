
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem
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
        Image,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.Image => "image",
                AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                "image" => AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.Image,
                "video" => AppAssetLibraryImagesPlacementsGetToManyRelatedIncludeItem.Video,
                _ => null,
            };
        }
    }
}