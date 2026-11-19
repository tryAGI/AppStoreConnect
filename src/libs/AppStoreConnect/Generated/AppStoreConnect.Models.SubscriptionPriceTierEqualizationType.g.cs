
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierEqualizationType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTierEqualizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierEqualizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierEqualizationType value)
        {
            return value switch
            {
                SubscriptionPriceTierEqualizationType.SubscriptionPriceTierEqualizations => "subscriptionPriceTierEqualizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierEqualizationType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTierEqualizations" => SubscriptionPriceTierEqualizationType.SubscriptionPriceTierEqualizations,
                _ => null,
            };
        }
    }
}