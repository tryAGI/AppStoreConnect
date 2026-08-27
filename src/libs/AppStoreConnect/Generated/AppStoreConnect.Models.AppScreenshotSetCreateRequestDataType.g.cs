
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetCreateRequestDataType value)
        {
            return value switch
            {
                AppScreenshotSetCreateRequestDataType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppScreenshotSetCreateRequestDataType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}