
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}