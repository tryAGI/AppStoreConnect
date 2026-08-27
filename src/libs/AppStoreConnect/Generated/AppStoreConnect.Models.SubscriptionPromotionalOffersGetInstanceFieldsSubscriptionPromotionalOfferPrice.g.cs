
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice
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
    public static class SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice.SubscriptionPricePoint,
                "territory" => SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionPromotionalOfferPrice.Territory,
                _ => null,
            };
        }
    }
}