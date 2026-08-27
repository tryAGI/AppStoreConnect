
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppSearchKeywordsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppSearchKeywordsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppSearchKeywordsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppSearchKeywordsLinkagesResponseDataItemType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppSearchKeywordsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppSearchKeywordsLinkagesResponseDataItemType.AppKeywords,
                _ => null,
            };
        }
    }
}