
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType.AppKeywords,
                _ => null,
            };
        }
    }
}