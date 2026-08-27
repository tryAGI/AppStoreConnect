
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint
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
    public static class SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}