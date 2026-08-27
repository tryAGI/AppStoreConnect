
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice
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
    public static class InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice.PricePoint => "pricePoint",
                InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "pricePoint" => InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice.PricePoint,
                "territory" => InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice.Territory,
                _ => null,
            };
        }
    }
}