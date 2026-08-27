
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotedPurchaseLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotedPurchaseLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotedPurchaseLinkageResponseDataType value)
        {
            return value switch
            {
                SubscriptionPromotedPurchaseLinkageResponseDataType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotedPurchaseLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => SubscriptionPromotedPurchaseLinkageResponseDataType.PromotedPurchases,
                _ => null,
            };
        }
    }
}