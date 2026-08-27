
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppInfo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppInfoLocalizationsGetInstanceIncludeItem.AppInfo => "appInfo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appInfo" => AppInfoLocalizationsGetInstanceIncludeItem.AppInfo,
                _ => null,
            };
        }
    }
}