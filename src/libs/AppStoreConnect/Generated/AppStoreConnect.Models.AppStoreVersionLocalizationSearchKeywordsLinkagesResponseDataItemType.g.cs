
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationSearchKeywordsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationSearchKeywordsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationSearchKeywordsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationSearchKeywordsLinkagesResponseDataItemType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationSearchKeywordsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppStoreVersionLocalizationSearchKeywordsLinkagesResponseDataItemType.AppKeywords,
                _ => null,
            };
        }
    }
}