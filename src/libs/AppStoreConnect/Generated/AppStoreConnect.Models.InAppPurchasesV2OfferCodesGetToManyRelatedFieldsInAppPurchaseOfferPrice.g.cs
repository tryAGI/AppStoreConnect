
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice
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
    public static class InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice value)
        {
            return value switch
            {
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice.PricePoint => "pricePoint",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "pricePoint" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice.PricePoint,
                "territory" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice.Territory,
                _ => null,
            };
        }
    }
}