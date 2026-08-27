
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppAvailabilityV2GetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppAvailabilityV2GetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppAvailabilityV2GetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppAvailabilityV2GetToOneRelatedIncludeItem.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppAvailabilityV2GetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territoryAvailabilities" => AppsAppAvailabilityV2GetToOneRelatedIncludeItem.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}