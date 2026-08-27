
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferPriceRelationshipsPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferPriceRelationshipsPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferPriceRelationshipsPricePointDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferPriceRelationshipsPricePointDataType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferPriceRelationshipsPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchaseOfferPriceRelationshipsPricePointDataType.InAppPurchasePricePoints,
                _ => null,
            };
        }
    }
}