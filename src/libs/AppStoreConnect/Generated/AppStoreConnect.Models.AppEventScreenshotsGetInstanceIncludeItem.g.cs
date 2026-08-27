
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventScreenshotsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppEventScreenshotsGetInstanceIncludeItem.AppEventLocalization => "appEventLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalization" => AppEventScreenshotsGetInstanceIncludeItem.AppEventLocalization,
                _ => null,
            };
        }
    }
}