
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsPromotedPurchaseDataType
    {
        /// <summary>
        ///
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsPromotedPurchaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsPromotedPurchaseDataType value)
        {
            return value switch
            {
                SubscriptionRelationshipsPromotedPurchaseDataType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsPromotedPurchaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => SubscriptionRelationshipsPromotedPurchaseDataType.PromotedPurchases,
                _ => null,
            };
        }
    }
}