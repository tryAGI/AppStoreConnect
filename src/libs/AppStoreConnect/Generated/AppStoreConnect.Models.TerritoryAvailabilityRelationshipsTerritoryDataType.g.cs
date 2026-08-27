
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum TerritoryAvailabilityRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryAvailabilityRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryAvailabilityRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                TerritoryAvailabilityRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryAvailabilityRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => TerritoryAvailabilityRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}