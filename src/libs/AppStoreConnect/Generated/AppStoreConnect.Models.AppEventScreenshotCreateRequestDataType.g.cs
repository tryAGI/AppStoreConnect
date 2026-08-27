
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventScreenshotCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotCreateRequestDataType value)
        {
            return value switch
            {
                AppEventScreenshotCreateRequestDataType.AppEventScreenshots => "appEventScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventScreenshots" => AppEventScreenshotCreateRequestDataType.AppEventScreenshots,
                _ => null,
            };
        }
    }
}