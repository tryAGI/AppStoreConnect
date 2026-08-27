
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationSearchKeywordsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationSearchKeywordsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationSearchKeywordsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationSearchKeywordsLinkagesRequestDataItemType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationSearchKeywordsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppStoreVersionLocalizationSearchKeywordsLinkagesRequestDataItemType.AppKeywords,
                _ => null,
            };
        }
    }
}