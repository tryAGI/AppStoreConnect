
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppTagType
    {
        /// <summary>
        ///
        /// </summary>
        AppTags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTagTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppTagType value)
        {
            return value switch
            {
                AppTagType.AppTags => "appTags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppTagType? ToEnum(string value)
        {
            return value switch
            {
                "appTags" => AppTagType.AppTags,
                _ => null,
            };
        }
    }
}