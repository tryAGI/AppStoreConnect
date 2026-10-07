
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem
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
    public static class AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem value)
        {
            return value switch
            {
                AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem.AppScreenshotsAndPreviews => "APP_SCREENSHOTS_AND_PREVIEWS",
                AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem.CreativeAssets => "CREATIVE_ASSETS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_SCREENSHOTS_AND_PREVIEWS" => AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem.AppScreenshotsAndPreviews,
                "CREATIVE_ASSETS" => AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem.CreativeAssets,
                _ => null,
            };
        }
    }
}