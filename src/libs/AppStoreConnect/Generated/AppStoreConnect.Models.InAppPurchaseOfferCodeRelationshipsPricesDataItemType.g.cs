
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeRelationshipsPricesDataItemType.InAppPurchaseOfferPrices => "inAppPurchaseOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferPrices" => InAppPurchaseOfferCodeRelationshipsPricesDataItemType.InAppPurchaseOfferPrices,
                _ => null,
            };
        }
    }
}