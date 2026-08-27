
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventVideoClipsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventVideoClipsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventVideoClipsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppEventVideoClipsGetInstanceIncludeItem.AppEventLocalization => "appEventLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventVideoClipsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalization" => AppEventVideoClipsGetInstanceIncludeItem.AppEventLocalization,
                _ => null,
            };
        }
    }
}