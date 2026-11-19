
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierInlineCreateType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTiers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierInlineCreateType value)
        {
            return value switch
            {
                SubscriptionPriceTierInlineCreateType.SubscriptionPriceTiers => "subscriptionPriceTiers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTiers" => SubscriptionPriceTierInlineCreateType.SubscriptionPriceTiers,
                _ => null,
            };
        }
    }
}