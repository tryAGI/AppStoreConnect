
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPricesLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricesLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricesLinkagesRequestDataItemType value)
        {
            return value switch
            {
                SubscriptionPricesLinkagesRequestDataItemType.SubscriptionPrices => "subscriptionPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricesLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPrices" => SubscriptionPricesLinkagesRequestDataItemType.SubscriptionPrices,
                _ => null,
            };
        }
    }
}