
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferPriceInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferPriceInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferPriceInlineCreateType value)
        {
            return value switch
            {
                InAppPurchaseOfferPriceInlineCreateType.InAppPurchaseOfferPrices => "inAppPurchaseOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferPriceInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferPrices" => InAppPurchaseOfferPriceInlineCreateType.InAppPurchaseOfferPrices,
                _ => null,
            };
        }
    }
}