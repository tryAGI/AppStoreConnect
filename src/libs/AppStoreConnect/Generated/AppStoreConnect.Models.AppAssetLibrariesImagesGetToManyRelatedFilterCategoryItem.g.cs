
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem
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
    public static class AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem value)
        {
            return value switch
            {
                AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem.AppScreenshotsAndPreviews => "APP_SCREENSHOTS_AND_PREVIEWS",
                AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem.CreativeAssets => "CREATIVE_ASSETS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_SCREENSHOTS_AND_PREVIEWS" => AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem.AppScreenshotsAndPreviews,
                "CREATIVE_ASSETS" => AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem.CreativeAssets,
                _ => null,
            };
        }
    }
}