
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionPricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints => "subscriptionPricePoints",
                SubscriptionPricesResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionPricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints,
                "territories" => SubscriptionPricesResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}