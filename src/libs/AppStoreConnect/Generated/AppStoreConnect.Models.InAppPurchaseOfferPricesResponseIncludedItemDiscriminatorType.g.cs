
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePricePoints,
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints,
                "territories" => InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}