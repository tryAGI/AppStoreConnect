
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseV2RelationshipsPromotedPurchaseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsPromotedPurchaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsPromotedPurchaseDataType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsPromotedPurchaseDataType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsPromotedPurchaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => InAppPurchaseV2RelationshipsPromotedPurchaseDataType.PromotedPurchases,
                _ => null,
            };
        }
    }
}