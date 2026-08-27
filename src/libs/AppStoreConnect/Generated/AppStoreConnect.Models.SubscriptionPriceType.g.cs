
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPriceType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceType value)
        {
            return value switch
            {
                SubscriptionPriceType.SubscriptionPrices => "subscriptionPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPrices" => SubscriptionPriceType.SubscriptionPrices,
                _ => null,
            };
        }
    }
}