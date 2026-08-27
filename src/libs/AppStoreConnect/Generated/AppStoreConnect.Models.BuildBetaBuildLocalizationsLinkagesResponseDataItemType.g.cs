
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaBuildLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaBuildLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaBuildLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaBuildLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BuildBetaBuildLocalizationsLinkagesResponseDataItemType.BetaBuildLocalizations => "betaBuildLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaBuildLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaBuildLocalizations" => BuildBetaBuildLocalizationsLinkagesResponseDataItemType.BetaBuildLocalizations,
                _ => null,
            };
        }
    }
}