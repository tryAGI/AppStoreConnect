
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceInlineCreateType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceInlineCreateType value)
        {
            return value switch
            {
                SubscriptionPriceInlineCreateType.SubscriptionPrices => "subscriptionPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPrices" => SubscriptionPriceInlineCreateType.SubscriptionPrices,
                _ => null,
            };
        }
    }
}