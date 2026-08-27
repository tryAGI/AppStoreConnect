
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageVersion,
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
        SearchKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsGetInstanceIncludeItem.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppCustomProductPageLocalizationsGetInstanceIncludeItem.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageLocalizationsGetInstanceIncludeItem.AppScreenshotSets => "appScreenshotSets",
                AppCustomProductPageLocalizationsGetInstanceIncludeItem.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppCustomProductPageLocalizationsGetInstanceIncludeItem.AppCustomProductPageVersion,
                "appPreviewSets" => AppCustomProductPageLocalizationsGetInstanceIncludeItem.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageLocalizationsGetInstanceIncludeItem.AppScreenshotSets,
                "searchKeywords" => AppCustomProductPageLocalizationsGetInstanceIncludeItem.SearchKeywords,
                _ => null,
            };
        }
    }
}