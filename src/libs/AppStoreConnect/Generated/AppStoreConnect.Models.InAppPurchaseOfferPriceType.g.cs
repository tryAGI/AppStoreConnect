
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferPriceType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferPriceType value)
        {
            return value switch
            {
                InAppPurchaseOfferPriceType.InAppPurchaseOfferPrices => "inAppPurchaseOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferPriceType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferPrices" => InAppPurchaseOfferPriceType.InAppPurchaseOfferPrices,
                _ => null,
            };
        }
    }
}