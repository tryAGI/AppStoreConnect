
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBuildLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        BetaBuildLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationType value)
        {
            return value switch
            {
                BetaBuildLocalizationType.BetaBuildLocalizations => "betaBuildLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "betaBuildLocalizations" => BetaBuildLocalizationType.BetaBuildLocalizations,
                _ => null,
            };
        }
    }
}