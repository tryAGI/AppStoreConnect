
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionPriceCreateRequestDataType.SubscriptionPrices => "subscriptionPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPrices" => SubscriptionPriceCreateRequestDataType.SubscriptionPrices,
                _ => null,
            };
        }
    }
}