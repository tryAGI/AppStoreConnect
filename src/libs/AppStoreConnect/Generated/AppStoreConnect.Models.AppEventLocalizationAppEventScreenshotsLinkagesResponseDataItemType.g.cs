
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationAppEventScreenshotsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationAppEventScreenshotsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationAppEventScreenshotsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppEventLocalizationAppEventScreenshotsLinkagesResponseDataItemType.AppEventScreenshots => "appEventScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationAppEventScreenshotsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEventScreenshots" => AppEventLocalizationAppEventScreenshotsLinkagesResponseDataItemType.AppEventScreenshots,
                _ => null,
            };
        }
    }
}