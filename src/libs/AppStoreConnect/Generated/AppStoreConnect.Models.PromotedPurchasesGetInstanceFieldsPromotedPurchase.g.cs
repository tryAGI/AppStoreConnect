
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromotedPurchasesGetInstanceFieldsPromotedPurchase
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseV2,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
        /// <summary>
        /// 
        /// </summary>
        VisibleForAllUsers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchasesGetInstanceFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchasesGetInstanceFieldsPromotedPurchase value)
        {
            return value switch
            {
                PromotedPurchasesGetInstanceFieldsPromotedPurchase.Enabled => "enabled",
                PromotedPurchasesGetInstanceFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                PromotedPurchasesGetInstanceFieldsPromotedPurchase.State => "state",
                PromotedPurchasesGetInstanceFieldsPromotedPurchase.Subscription => "subscription",
                PromotedPurchasesGetInstanceFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchasesGetInstanceFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => PromotedPurchasesGetInstanceFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => PromotedPurchasesGetInstanceFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => PromotedPurchasesGetInstanceFieldsPromotedPurchase.State,
                "subscription" => PromotedPurchasesGetInstanceFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => PromotedPurchasesGetInstanceFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}