
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}