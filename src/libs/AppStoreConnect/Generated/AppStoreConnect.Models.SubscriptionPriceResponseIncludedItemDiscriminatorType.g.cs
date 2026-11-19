
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTiers,
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionPriceResponseIncludedItemDiscriminatorType.SubscriptionPricePoints => "subscriptionPricePoints",
                SubscriptionPriceResponseIncludedItemDiscriminatorType.SubscriptionPriceTiers => "subscriptionPriceTiers",
                SubscriptionPriceResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionPriceResponseIncludedItemDiscriminatorType.SubscriptionPricePoints,
                "subscriptionPriceTiers" => SubscriptionPriceResponseIncludedItemDiscriminatorType.SubscriptionPriceTiers,
                "territories" => SubscriptionPriceResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}