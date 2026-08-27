
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice
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
    public static class SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice.SubscriptionPricePoint,
                "territory" => SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice.Territory,
                _ => null,
            };
        }
    }
}