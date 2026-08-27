
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType value)
        {
            return value switch
            {
                InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchasePriceInlineCreateRelationshipsInAppPurchaseV2DataType.InAppPurchases,
                _ => null,
            };
        }
    }
}