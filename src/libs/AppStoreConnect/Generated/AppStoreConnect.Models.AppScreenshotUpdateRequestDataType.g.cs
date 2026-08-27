
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotUpdateRequestDataType value)
        {
            return value switch
            {
                AppScreenshotUpdateRequestDataType.AppScreenshots => "appScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshots" => AppScreenshotUpdateRequestDataType.AppScreenshots,
                _ => null,
            };
        }
    }
}