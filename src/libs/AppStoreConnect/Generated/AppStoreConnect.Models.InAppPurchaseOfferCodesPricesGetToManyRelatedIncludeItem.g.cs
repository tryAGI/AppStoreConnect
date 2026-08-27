
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem
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
    public static class InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem.PricePoint => "pricePoint",
                InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "pricePoint" => InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem.PricePoint,
                "territory" => InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}