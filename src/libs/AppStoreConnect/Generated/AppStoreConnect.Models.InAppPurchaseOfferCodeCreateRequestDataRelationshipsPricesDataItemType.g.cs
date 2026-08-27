
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCreateRequestDataRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCreateRequestDataRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCreateRequestDataRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCreateRequestDataRelationshipsPricesDataItemType.InAppPurchaseOfferPrices => "inAppPurchaseOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCreateRequestDataRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferPrices" => InAppPurchaseOfferCodeCreateRequestDataRelationshipsPricesDataItemType.InAppPurchaseOfferPrices,
                _ => null,
            };
        }
    }
}