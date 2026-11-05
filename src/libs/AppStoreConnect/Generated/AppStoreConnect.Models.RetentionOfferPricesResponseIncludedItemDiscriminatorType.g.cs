
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferPricesResponseIncludedItemDiscriminatorType
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
    public static class RetentionOfferPricesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferPricesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                RetentionOfferPricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints => "subscriptionPricePoints",
                RetentionOfferPricesResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferPricesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => RetentionOfferPricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints,
                "territories" => RetentionOfferPricesResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}