
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOfferInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPromotionalOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferInlineCreateType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferInlineCreateType.SubscriptionPromotionalOffers => "subscriptionPromotionalOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOffers" => SubscriptionPromotionalOfferInlineCreateType.SubscriptionPromotionalOffers,
                _ => null,
            };
        }
    }
}