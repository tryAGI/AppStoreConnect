
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceIncludeItem
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
    public static class AppAssetLibraryPlacementsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryPlacementsGetInstanceIncludeItem.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryPlacementsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryPlacementsGetInstanceIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryPlacementsGetInstanceIncludeItem.Image => "image",
                AppAssetLibraryPlacementsGetInstanceIncludeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryPlacementsGetInstanceIncludeItem.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryPlacementsGetInstanceIncludeItem.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryPlacementsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryPlacementsGetInstanceIncludeItem.AppStoreVersionLocalization,
                "image" => AppAssetLibraryPlacementsGetInstanceIncludeItem.Image,
                "video" => AppAssetLibraryPlacementsGetInstanceIncludeItem.Video,
                _ => null,
            };
        }
    }
}