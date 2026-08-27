
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewType
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewType value)
        {
            return value switch
            {
                AppPreviewType.AppPreviews => "appPreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviews" => AppPreviewType.AppPreviews,
                _ => null,
            };
        }
    }
}