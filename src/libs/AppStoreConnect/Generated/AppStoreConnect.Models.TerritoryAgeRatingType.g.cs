
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerritoryAgeRatingType
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAgeRatings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryAgeRatingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryAgeRatingType value)
        {
            return value switch
            {
                TerritoryAgeRatingType.TerritoryAgeRatings => "territoryAgeRatings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryAgeRatingType? ToEnum(string value)
        {
            return value switch
            {
                "territoryAgeRatings" => TerritoryAgeRatingType.TerritoryAgeRatings,
                _ => null,
            };
        }
    }
}