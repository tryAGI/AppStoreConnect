
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierEqualizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTierEqualizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierEqualizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierEqualizationCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionPriceTierEqualizationCreateRequestDataType.SubscriptionPriceTierEqualizations => "subscriptionPriceTierEqualizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierEqualizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTierEqualizations" => SubscriptionPriceTierEqualizationCreateRequestDataType.SubscriptionPriceTierEqualizations,
                _ => null,
            };
        }
    }
}