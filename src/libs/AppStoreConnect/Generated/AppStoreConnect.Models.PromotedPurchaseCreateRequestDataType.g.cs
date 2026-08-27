
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromotedPurchaseCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchaseCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchaseCreateRequestDataType value)
        {
            return value switch
            {
                PromotedPurchaseCreateRequestDataType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchaseCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => PromotedPurchaseCreateRequestDataType.PromotedPurchases,
                _ => null,
            };
        }
    }
}