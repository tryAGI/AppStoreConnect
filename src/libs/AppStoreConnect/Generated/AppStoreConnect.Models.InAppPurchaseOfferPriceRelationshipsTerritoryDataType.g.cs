
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferPriceRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferPriceRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferPriceRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferPriceRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferPriceRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchaseOfferPriceRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}