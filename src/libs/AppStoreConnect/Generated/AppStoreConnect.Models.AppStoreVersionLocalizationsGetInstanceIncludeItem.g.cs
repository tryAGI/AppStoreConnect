
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
        /// <summary>
        /// 
        /// </summary>
        AppScreenshotSets,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
        /// <summary>
        /// 
        /// </summary>
        SearchKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsGetInstanceIncludeItem.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsGetInstanceIncludeItem.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsGetInstanceIncludeItem.AppStoreVersion => "appStoreVersion",
                AppStoreVersionLocalizationsGetInstanceIncludeItem.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationsGetInstanceIncludeItem.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsGetInstanceIncludeItem.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionLocalizationsGetInstanceIncludeItem.AppStoreVersion,
                "searchKeywords" => AppStoreVersionLocalizationsGetInstanceIncludeItem.SearchKeywords,
                _ => null,
            };
        }
    }
}