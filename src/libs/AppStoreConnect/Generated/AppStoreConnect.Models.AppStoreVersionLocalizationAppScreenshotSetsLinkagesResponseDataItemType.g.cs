
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationAppScreenshotSetsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationAppScreenshotSetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationAppScreenshotSetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationAppScreenshotSetsLinkagesResponseDataItemType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationAppScreenshotSetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppStoreVersionLocalizationAppScreenshotSetsLinkagesResponseDataItemType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}