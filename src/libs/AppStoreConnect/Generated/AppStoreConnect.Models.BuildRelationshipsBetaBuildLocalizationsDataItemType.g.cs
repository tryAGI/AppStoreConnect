
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildRelationshipsBetaBuildLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaBuildLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsBetaBuildLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsBetaBuildLocalizationsDataItemType value)
        {
            return value switch
            {
                BuildRelationshipsBetaBuildLocalizationsDataItemType.BetaBuildLocalizations => "betaBuildLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsBetaBuildLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaBuildLocalizations" => BuildRelationshipsBetaBuildLocalizationsDataItemType.BetaBuildLocalizations,
                _ => null,
            };
        }
    }
}