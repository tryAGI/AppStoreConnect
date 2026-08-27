
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePrice
    {
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
    public static class SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePrice value)
        {
            return value switch
            {
                SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePrice.SubscriptionPricePoint,
                "territory" => SubscriptionOfferCodesPricesGetToManyRelatedFieldsSubscriptionOfferCodePrice.Territory,
                _ => null,
            };
        }
    }
}