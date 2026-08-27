
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOfferPriceType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPromotionalOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferPriceType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferPriceType.SubscriptionPromotionalOfferPrices => "subscriptionPromotionalOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferPriceType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOfferPrices" => SubscriptionPromotionalOfferPriceType.SubscriptionPromotionalOfferPrices,
                _ => null,
            };
        }
    }
}