
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromotedPurchaseResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchaseResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchaseResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                PromotedPurchaseResponseIncludedItemDiscriminatorType.InAppPurchases => "inAppPurchases",
                PromotedPurchaseResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchaseResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => PromotedPurchaseResponseIncludedItemDiscriminatorType.InAppPurchases,
                "subscriptions" => PromotedPurchaseResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}