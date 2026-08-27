
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerritoryAvailabilityInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryAvailabilityInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryAvailabilityInlineCreateType value)
        {
            return value switch
            {
                TerritoryAvailabilityInlineCreateType.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryAvailabilityInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "territoryAvailabilities" => TerritoryAvailabilityInlineCreateType.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}