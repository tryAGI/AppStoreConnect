
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferPricesResponseIncludedItemDiscriminatorType
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
    public static class WinBackOfferPricesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferPricesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                WinBackOfferPricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints => "subscriptionPricePoints",
                WinBackOfferPricesResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferPricesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => WinBackOfferPricesResponseIncludedItemDiscriminatorType.SubscriptionPricePoints,
                "territories" => WinBackOfferPricesResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}