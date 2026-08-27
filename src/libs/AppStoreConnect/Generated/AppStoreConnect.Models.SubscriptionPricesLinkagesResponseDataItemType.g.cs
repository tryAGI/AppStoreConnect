
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPricesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionPricesLinkagesResponseDataItemType.SubscriptionPrices => "subscriptionPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPrices" => SubscriptionPricesLinkagesResponseDataItemType.SubscriptionPrices,
                _ => null,
            };
        }
    }
}