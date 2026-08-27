
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodePriceType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodePriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodePriceType value)
        {
            return value switch
            {
                SubscriptionOfferCodePriceType.SubscriptionOfferCodePrices => "subscriptionOfferCodePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodePriceType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodePrices" => SubscriptionOfferCodePriceType.SubscriptionOfferCodePrices,
                _ => null,
            };
        }
    }
}