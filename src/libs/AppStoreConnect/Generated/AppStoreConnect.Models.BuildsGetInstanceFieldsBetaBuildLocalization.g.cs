
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsBetaBuildLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        WhatsNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsGetInstanceFieldsBetaBuildLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBetaBuildLocalization value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBetaBuildLocalization.Build => "build",
                BuildsGetInstanceFieldsBetaBuildLocalization.Locale => "locale",
                BuildsGetInstanceFieldsBetaBuildLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBetaBuildLocalization? ToEnum(string value)
        {
            return value switch
            {
                "build" => BuildsGetInstanceFieldsBetaBuildLocalization.Build,
                "locale" => BuildsGetInstanceFieldsBetaBuildLocalization.Locale,
                "whatsNew" => BuildsGetInstanceFieldsBetaBuildLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}