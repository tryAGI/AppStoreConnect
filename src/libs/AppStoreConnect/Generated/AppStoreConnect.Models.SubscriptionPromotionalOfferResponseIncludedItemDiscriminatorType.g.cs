
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOfferPrices => "subscriptionPromotionalOfferPrices",
                SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOfferPrices" => SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorType.SubscriptionPromotionalOfferPrices,
                "subscriptions" => SubscriptionPromotionalOfferResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}