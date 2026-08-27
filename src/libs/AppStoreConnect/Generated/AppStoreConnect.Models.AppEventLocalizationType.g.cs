
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationType value)
        {
            return value switch
            {
                AppEventLocalizationType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventLocalizationType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}