
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotSetAppScreenshotsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetAppScreenshotsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetAppScreenshotsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppScreenshotSetAppScreenshotsLinkagesResponseDataItemType.AppScreenshots => "appScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetAppScreenshotsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshots" => AppScreenshotSetAppScreenshotsLinkagesResponseDataItemType.AppScreenshots,
                _ => null,
            };
        }
    }
}