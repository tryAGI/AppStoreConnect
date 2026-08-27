
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePricePointRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePricePointRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePricePointRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                InAppPurchasePricePointRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePricePointRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchasePricePointRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}