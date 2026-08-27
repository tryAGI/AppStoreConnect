
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppEventsGetInstanceIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppEventsGetInstanceIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}