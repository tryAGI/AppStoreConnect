
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationAppScreenshotSetsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationAppScreenshotSetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationAppScreenshotSetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationAppScreenshotSetsLinkagesResponseDataItemType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationAppScreenshotSetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppCustomProductPageLocalizationAppScreenshotSetsLinkagesResponseDataItemType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}