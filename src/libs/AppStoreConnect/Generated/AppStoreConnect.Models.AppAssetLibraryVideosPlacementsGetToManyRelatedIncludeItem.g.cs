
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.Image => "image",
                AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                "image" => AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.Image,
                "video" => AppAssetLibraryVideosPlacementsGetToManyRelatedIncludeItem.Video,
                _ => null,
            };
        }
    }
}