
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint
    {
        /// <summary>
        ///
        /// </summary>
        CustomerPrice,
        /// <summary>
        ///
        /// </summary>
        Equalizations,
        /// <summary>
        ///
        /// </summary>
        Proceeds,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice => "customerPrice",
                InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations => "equalizations",
                InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds => "proceeds",
                InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint? ToEnum(string value)
        {
            return value switch
            {
                "customerPrice" => InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice,
                "equalizations" => InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations,
                "proceeds" => InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds,
                "territory" => InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint.Territory,
                _ => null,
            };
        }
    }
}