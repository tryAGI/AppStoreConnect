
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem
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
    public static class AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.AppPreviewSets => "appPreviewSets",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.AppStoreVersion,
                "searchKeywords" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem.SearchKeywords,
                _ => null,
            };
        }
    }
}