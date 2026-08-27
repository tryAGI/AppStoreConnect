
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization
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
    public static class BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization value)
        {
            return value switch
            {
                BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization.Build => "build",
                BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization.Locale => "locale",
                BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization.Build,
                "locale" => BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization.Locale,
                "whatsNew" => BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}