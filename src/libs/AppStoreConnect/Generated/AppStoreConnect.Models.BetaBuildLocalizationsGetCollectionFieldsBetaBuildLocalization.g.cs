
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization
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
    public static class BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization value)
        {
            return value switch
            {
                BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization.Build => "build",
                BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization.Locale => "locale",
                BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization.Build,
                "locale" => BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization.Locale,
                "whatsNew" => BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}