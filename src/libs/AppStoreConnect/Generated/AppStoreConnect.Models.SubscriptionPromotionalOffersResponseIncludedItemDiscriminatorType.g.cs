
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPromotionalOfferPrices,
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOfferPrices => "subscriptionPromotionalOfferPrices",
                SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOfferPrices" => SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOfferPrices,
                "subscriptions" => SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}