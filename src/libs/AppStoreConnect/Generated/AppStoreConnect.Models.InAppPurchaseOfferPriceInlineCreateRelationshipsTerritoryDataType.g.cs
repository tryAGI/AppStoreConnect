
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferPriceInlineCreateRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferPriceInlineCreateRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferPriceInlineCreateRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferPriceInlineCreateRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferPriceInlineCreateRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchaseOfferPriceInlineCreateRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}