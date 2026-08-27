
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipHeaderImageType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipHeaderImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipHeaderImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipHeaderImageType value)
        {
            return value switch
            {
                AppClipHeaderImageType.AppClipHeaderImages => "appClipHeaderImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipHeaderImageType? ToEnum(string value)
        {
            return value switch
            {
                "appClipHeaderImages" => AppClipHeaderImageType.AppClipHeaderImages,
                _ => null,
            };
        }
    }
}