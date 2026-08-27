
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PromotedPurchasesResponseIncludedItemDiscriminatorType
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
    public static class PromotedPurchasesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchasesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                PromotedPurchasesResponseIncludedItemDiscriminatorType.InAppPurchases => "inAppPurchases",
                PromotedPurchasesResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchasesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => PromotedPurchasesResponseIncludedItemDiscriminatorType.InAppPurchases,
                "subscriptions" => PromotedPurchasesResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}