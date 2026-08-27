
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie
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
    public static class AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie value)
        {
            return value switch
            {
                AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie.AvailableInNewTerritories,
                "territoryAvailabilities" => AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}