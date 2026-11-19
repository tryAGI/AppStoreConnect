
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice
    {
        /// <summary>
        ///
        /// </summary>
        AdditionalPriceTiers,
        /// <summary>
        ///
        /// </summary>
        PlanType,
        /// <summary>
        ///
        /// </summary>
        Preserved,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice value)
        {
            return value switch
            {
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.AdditionalPriceTiers => "additionalPriceTiers",
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.PlanType => "planType",
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.Preserved => "preserved",
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.StartDate => "startDate",
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice? ToEnum(string value)
        {
            return value switch
            {
                "additionalPriceTiers" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.AdditionalPriceTiers,
                "planType" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.PlanType,
                "preserved" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.Preserved,
                "startDate" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.StartDate,
                "subscriptionPricePoint" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.SubscriptionPricePoint,
                "territory" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPrice.Territory,
                _ => null,
            };
        }
    }
}