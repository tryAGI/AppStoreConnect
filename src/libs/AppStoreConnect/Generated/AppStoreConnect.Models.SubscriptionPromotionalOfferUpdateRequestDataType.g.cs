
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOfferUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPromotionalOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferUpdateRequestDataType.SubscriptionPromotionalOffers => "subscriptionPromotionalOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOffers" => SubscriptionPromotionalOfferUpdateRequestDataType.SubscriptionPromotionalOffers,
                _ => null,
            };
        }
    }
}