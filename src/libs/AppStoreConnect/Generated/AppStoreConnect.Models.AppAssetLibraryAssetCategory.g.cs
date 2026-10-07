
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryAssetCategory
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotsAndPreviews,
        /// <summary>
        ///
        /// </summary>
        CreativeAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryAssetCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryAssetCategory value)
        {
            return value switch
            {
                AppAssetLibraryAssetCategory.AppScreenshotsAndPreviews => "APP_SCREENSHOTS_AND_PREVIEWS",
                AppAssetLibraryAssetCategory.CreativeAssets => "CREATIVE_ASSETS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryAssetCategory? ToEnum(string value)
        {
            return value switch
            {
                "APP_SCREENSHOTS_AND_PREVIEWS" => AppAssetLibraryAssetCategory.AppScreenshotsAndPreviews,
                "CREATIVE_ASSETS" => AppAssetLibraryAssetCategory.CreativeAssets,
                _ => null,
            };
        }
    }
}