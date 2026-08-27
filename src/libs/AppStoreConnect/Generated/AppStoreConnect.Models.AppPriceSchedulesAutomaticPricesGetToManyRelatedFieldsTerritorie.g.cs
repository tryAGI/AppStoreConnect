
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}