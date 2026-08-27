
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAvailabilityV2TerritoryAvailabilitiesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilityV2TerritoryAvailabilitiesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilityV2TerritoryAvailabilitiesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAvailabilityV2TerritoryAvailabilitiesLinkagesResponseDataItemType.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilityV2TerritoryAvailabilitiesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territoryAvailabilities" => AppAvailabilityV2TerritoryAvailabilitiesLinkagesResponseDataItemType.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}