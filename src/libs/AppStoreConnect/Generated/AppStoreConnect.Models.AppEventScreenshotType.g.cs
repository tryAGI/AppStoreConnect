
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventScreenshotType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotType value)
        {
            return value switch
            {
                AppEventScreenshotType.AppEventScreenshots => "appEventScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotType? ToEnum(string value)
        {
            return value switch
            {
                "appEventScreenshots" => AppEventScreenshotType.AppEventScreenshots,
                _ => null,
            };
        }
    }
}