
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetAppScreenshotsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetAppScreenshotsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetAppScreenshotsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                AppScreenshotSetAppScreenshotsLinkagesRequestDataItemType.AppScreenshots => "appScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetAppScreenshotsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshots" => AppScreenshotSetAppScreenshotsLinkagesRequestDataItemType.AppScreenshots,
                _ => null,
            };
        }
    }
}