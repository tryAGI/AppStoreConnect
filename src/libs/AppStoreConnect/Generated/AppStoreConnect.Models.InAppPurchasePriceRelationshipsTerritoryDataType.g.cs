
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                InAppPurchasePriceRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchasePriceRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}