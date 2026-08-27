
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferPriceInlineCreateRelationshipsPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferPriceInlineCreateRelationshipsPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferPriceInlineCreateRelationshipsPricePointDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferPriceInlineCreateRelationshipsPricePointDataType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferPriceInlineCreateRelationshipsPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchaseOfferPriceInlineCreateRelationshipsPricePointDataType.InAppPurchasePricePoints,
                _ => null,
            };
        }
    }
}