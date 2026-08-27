
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}