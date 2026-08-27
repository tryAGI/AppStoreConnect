
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodePricesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodePricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodePricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionOfferCodePricesLinkagesResponseDataItemType.SubscriptionOfferCodePrices => "subscriptionOfferCodePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodePricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodePrices" => SubscriptionOfferCodePricesLinkagesResponseDataItemType.SubscriptionOfferCodePrices,
                _ => null,
            };
        }
    }
}