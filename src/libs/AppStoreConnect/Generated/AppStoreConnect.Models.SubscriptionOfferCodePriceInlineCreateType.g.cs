
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodePriceInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodePriceInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodePriceInlineCreateType value)
        {
            return value switch
            {
                SubscriptionOfferCodePriceInlineCreateType.SubscriptionOfferCodePrices => "subscriptionOfferCodePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodePriceInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodePrices" => SubscriptionOfferCodePriceInlineCreateType.SubscriptionOfferCodePrices,
                _ => null,
            };
        }
    }
}