
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppScreenshotsGetInstanceIncludeItem.AppScreenshotSet => "appScreenshotSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppScreenshotsGetInstanceIncludeItem.AppScreenshotSet,
                _ => null,
            };
        }
    }
}