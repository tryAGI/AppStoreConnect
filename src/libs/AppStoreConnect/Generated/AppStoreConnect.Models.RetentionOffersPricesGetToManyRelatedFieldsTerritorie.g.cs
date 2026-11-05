
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersPricesGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOffersPricesGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersPricesGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                RetentionOffersPricesGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersPricesGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => RetentionOffersPricesGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}