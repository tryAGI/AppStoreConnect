
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodePricesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodePricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodePricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodePricesLinkagesResponseDataItemType.InAppPurchaseOfferPrices => "inAppPurchaseOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodePricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferPrices" => InAppPurchaseOfferCodePricesLinkagesResponseDataItemType.InAppPurchaseOfferPrices,
                _ => null,
            };
        }
    }
}