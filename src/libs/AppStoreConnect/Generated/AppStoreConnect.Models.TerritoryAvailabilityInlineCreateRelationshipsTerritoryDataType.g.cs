
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum TerritoryAvailabilityInlineCreateRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryAvailabilityInlineCreateRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryAvailabilityInlineCreateRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                TerritoryAvailabilityInlineCreateRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryAvailabilityInlineCreateRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => TerritoryAvailabilityInlineCreateRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}