
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2PromotedPurchaseLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2PromotedPurchaseLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2PromotedPurchaseLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchaseV2PromotedPurchaseLinkageResponseDataType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2PromotedPurchaseLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => InAppPurchaseV2PromotedPurchaseLinkageResponseDataType.PromotedPurchases,
                _ => null,
            };
        }
    }
}