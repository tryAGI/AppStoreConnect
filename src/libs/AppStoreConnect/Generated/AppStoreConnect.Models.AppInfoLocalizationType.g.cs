
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfoLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationType value)
        {
            return value switch
            {
                AppInfoLocalizationType.AppInfoLocalizations => "appInfoLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "appInfoLocalizations" => AppInfoLocalizationType.AppInfoLocalizations,
                _ => null,
            };
        }
    }
}