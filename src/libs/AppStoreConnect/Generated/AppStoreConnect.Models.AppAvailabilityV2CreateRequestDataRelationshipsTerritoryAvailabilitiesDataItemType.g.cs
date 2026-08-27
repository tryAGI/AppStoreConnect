
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType value)
        {
            return value switch
            {
                AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territoryAvailabilities" => AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilitiesDataItemType.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}