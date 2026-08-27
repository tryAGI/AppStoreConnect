
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerritoryAvailabilityType
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryAvailabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryAvailabilityType value)
        {
            return value switch
            {
                TerritoryAvailabilityType.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryAvailabilityType? ToEnum(string value)
        {
            return value switch
            {
                "territoryAvailabilities" => TerritoryAvailabilityType.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}