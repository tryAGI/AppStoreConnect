
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territory" => AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}