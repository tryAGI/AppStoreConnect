
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAvailabilitiesV2GetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        TerritoryAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilitiesV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilitiesV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                AppAvailabilitiesV2GetInstanceIncludeItem.TerritoryAvailabilities => "territoryAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilitiesV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territoryAvailabilities" => AppAvailabilitiesV2GetInstanceIncludeItem.TerritoryAvailabilities,
                _ => null,
            };
        }
    }
}