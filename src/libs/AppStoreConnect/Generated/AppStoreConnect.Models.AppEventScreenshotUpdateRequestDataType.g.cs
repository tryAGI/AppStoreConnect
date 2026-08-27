
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventScreenshotUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotUpdateRequestDataType value)
        {
            return value switch
            {
                AppEventScreenshotUpdateRequestDataType.AppEventScreenshots => "appEventScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventScreenshots" => AppEventScreenshotUpdateRequestDataType.AppEventScreenshots,
                _ => null,
            };
        }
    }
}