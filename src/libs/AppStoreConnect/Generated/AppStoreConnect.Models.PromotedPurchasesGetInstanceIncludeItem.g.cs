
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PromotedPurchasesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseV2,
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                PromotedPurchasesGetInstanceIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                PromotedPurchasesGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => PromotedPurchasesGetInstanceIncludeItem.InAppPurchaseV2,
                "subscription" => PromotedPurchasesGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}