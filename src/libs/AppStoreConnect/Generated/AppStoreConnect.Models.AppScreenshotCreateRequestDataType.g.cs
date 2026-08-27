
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotCreateRequestDataType value)
        {
            return value switch
            {
                AppScreenshotCreateRequestDataType.AppScreenshots => "appScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshots" => AppScreenshotCreateRequestDataType.AppScreenshots,
                _ => null,
            };
        }
    }
}