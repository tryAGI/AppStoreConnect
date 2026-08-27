
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromotedPurchaseRelationshipsInAppPurchaseV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchaseRelationshipsInAppPurchaseV2DataType value)
        {
            return value switch
            {
                PromotedPurchaseRelationshipsInAppPurchaseV2DataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchaseRelationshipsInAppPurchaseV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => PromotedPurchaseRelationshipsInAppPurchaseV2DataType.InAppPurchases,
                _ => null,
            };
        }
    }
}