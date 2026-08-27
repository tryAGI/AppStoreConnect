
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationSearchKeywordsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationSearchKeywordsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationSearchKeywordsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationSearchKeywordsLinkagesRequestDataItemType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationSearchKeywordsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppCustomProductPageLocalizationSearchKeywordsLinkagesRequestDataItemType.AppKeywords,
                _ => null,
            };
        }
    }
}