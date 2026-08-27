
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2RelationshipsPricePointsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsPricePointsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsPricePointsDataItemType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsPricePointsDataItemType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsPricePointsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchaseV2RelationshipsPricePointsDataItemType.InAppPurchasePricePoints,
                _ => null,
            };
        }
    }
}