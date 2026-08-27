
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventVideoClipUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEventVideoClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventVideoClipUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventVideoClipUpdateRequestDataType value)
        {
            return value switch
            {
                AppEventVideoClipUpdateRequestDataType.AppEventVideoClips => "appEventVideoClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventVideoClipUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventVideoClips" => AppEventVideoClipUpdateRequestDataType.AppEventVideoClips,
                _ => null,
            };
        }
    }
}