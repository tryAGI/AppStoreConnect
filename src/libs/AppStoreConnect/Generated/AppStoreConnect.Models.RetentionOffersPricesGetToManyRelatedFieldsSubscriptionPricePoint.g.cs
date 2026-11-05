
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint
    {
        /// <summary>
        ///
        /// </summary>
        AdjustedEqualizations,
        /// <summary>
        ///
        /// </summary>
        CustomerPrice,
        /// <summary>
        ///
        /// </summary>
        Equalizations,
        /// <summary>
        ///
        /// </summary>
        Proceeds,
        /// <summary>
        ///
        /// </summary>
        ProceedsYear2,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}