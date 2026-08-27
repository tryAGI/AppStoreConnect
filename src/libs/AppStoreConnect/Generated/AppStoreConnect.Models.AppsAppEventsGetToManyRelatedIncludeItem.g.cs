
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppEventsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppEventsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEventsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppEventsGetToManyRelatedIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEventsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppsAppEventsGetToManyRelatedIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}