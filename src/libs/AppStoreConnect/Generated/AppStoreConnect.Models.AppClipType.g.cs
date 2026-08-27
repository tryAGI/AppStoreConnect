
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipType value)
        {
            return value switch
            {
                AppClipType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppClipType.AppClips,
                _ => null,
            };
        }
    }
}