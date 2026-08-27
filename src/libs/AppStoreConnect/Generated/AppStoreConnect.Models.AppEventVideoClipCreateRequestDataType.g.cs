
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventVideoClipCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventVideoClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventVideoClipCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventVideoClipCreateRequestDataType value)
        {
            return value switch
            {
                AppEventVideoClipCreateRequestDataType.AppEventVideoClips => "appEventVideoClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventVideoClipCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventVideoClips" => AppEventVideoClipCreateRequestDataType.AppEventVideoClips,
                _ => null,
            };
        }
    }
}