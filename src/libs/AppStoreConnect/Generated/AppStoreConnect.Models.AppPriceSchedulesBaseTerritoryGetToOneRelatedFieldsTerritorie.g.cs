
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie value)
        {
            return value switch
            {
                AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}