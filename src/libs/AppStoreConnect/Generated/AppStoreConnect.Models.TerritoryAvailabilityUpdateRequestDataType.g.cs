
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerritoryAvailabilityUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryAvailabilityUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryAvailabilityUpdateRequestDataType value)
        {
            return value switch
            {
                TerritoryAvailabilityUpdateRequestDataType.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryAvailabilityUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "territoryAvailabilities" => TerritoryAvailabilityUpdateRequestDataType.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}