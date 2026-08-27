
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationSearchKeywordsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationSearchKeywordsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationSearchKeywordsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationSearchKeywordsLinkagesResponseDataItemType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationSearchKeywordsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppCustomProductPageLocalizationSearchKeywordsLinkagesResponseDataItemType.AppKeywords,
                _ => null,
            };
        }
    }
}