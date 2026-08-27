
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie
    {
        /// <summary>
        ///
        /// </summary>
        AvailableInNewTerritories,
        /// <summary>
        ///
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie value)
        {
            return value switch
            {
                AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie.AvailableInNewTerritories,
                "territoryAvailabilities" => AppsAppAvailabilityV2GetToOneRelatedFieldsAppAvailabilitie.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}