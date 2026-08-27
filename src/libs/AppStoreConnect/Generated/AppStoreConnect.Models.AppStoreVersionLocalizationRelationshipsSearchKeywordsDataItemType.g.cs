
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType.AppKeywords,
                _ => null,
            };
        }
    }
}