
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppPriceScheduleGetToOneRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie value)
        {
            return value switch
            {
                AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}