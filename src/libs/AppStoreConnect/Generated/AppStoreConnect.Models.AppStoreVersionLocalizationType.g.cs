
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppStoreVersionLocalizationType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}