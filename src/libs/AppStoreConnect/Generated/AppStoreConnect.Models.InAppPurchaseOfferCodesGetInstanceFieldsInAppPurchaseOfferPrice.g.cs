
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice
    {
        /// <summary>
        ///
        /// </summary>
        PricePoint,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice.PricePoint => "pricePoint",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "pricePoint" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice.PricePoint,
                "territory" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferPrice.Territory,
                _ => null,
            };
        }
    }
}