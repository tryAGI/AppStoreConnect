
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromotedPurchaseUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchaseUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchaseUpdateRequestDataType value)
        {
            return value switch
            {
                PromotedPurchaseUpdateRequestDataType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchaseUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => PromotedPurchaseUpdateRequestDataType.PromotedPurchases,
                _ => null,
            };
        }
    }
}