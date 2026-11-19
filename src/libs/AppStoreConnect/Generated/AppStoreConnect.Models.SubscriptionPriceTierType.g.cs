
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTiers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierType value)
        {
            return value switch
            {
                SubscriptionPriceTierType.SubscriptionPriceTiers => "subscriptionPriceTiers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTiers" => SubscriptionPriceTierType.SubscriptionPriceTiers,
                _ => null,
            };
        }
    }
}