
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints => "subscriptionPricePoints",
                SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints,
                "territories" => SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}