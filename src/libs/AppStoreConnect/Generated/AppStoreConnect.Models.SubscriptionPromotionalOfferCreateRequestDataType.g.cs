
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOfferCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPromotionalOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferCreateRequestDataType.SubscriptionPromotionalOffers => "subscriptionPromotionalOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOffers" => SubscriptionPromotionalOfferCreateRequestDataType.SubscriptionPromotionalOffers,
                _ => null,
            };
        }
    }
}