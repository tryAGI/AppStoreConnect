
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOfferType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPromotionalOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferType.SubscriptionPromotionalOffers => "subscriptionPromotionalOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOffers" => SubscriptionPromotionalOfferType.SubscriptionPromotionalOffers,
                _ => null,
            };
        }
    }
}