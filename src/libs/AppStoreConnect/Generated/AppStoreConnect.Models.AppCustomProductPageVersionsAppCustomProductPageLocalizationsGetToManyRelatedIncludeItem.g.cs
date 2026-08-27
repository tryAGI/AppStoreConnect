
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem
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
    public static class AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.AppScreenshotSets => "appScreenshotSets",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.AppCustomProductPageVersion,
                "appPreviewSets" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.AppScreenshotSets,
                "searchKeywords" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem.SearchKeywords,
                _ => null,
            };
        }
    }
}