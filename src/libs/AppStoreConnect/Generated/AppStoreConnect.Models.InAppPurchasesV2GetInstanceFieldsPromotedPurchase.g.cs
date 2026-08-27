
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsPromotedPurchase
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
    public static class InAppPurchasesV2GetInstanceFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsPromotedPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsPromotedPurchase.Enabled => "enabled",
                InAppPurchasesV2GetInstanceFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2GetInstanceFieldsPromotedPurchase.State => "state",
                InAppPurchasesV2GetInstanceFieldsPromotedPurchase.Subscription => "subscription",
                InAppPurchasesV2GetInstanceFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => InAppPurchasesV2GetInstanceFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => InAppPurchasesV2GetInstanceFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => InAppPurchasesV2GetInstanceFieldsPromotedPurchase.State,
                "subscription" => InAppPurchasesV2GetInstanceFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => InAppPurchasesV2GetInstanceFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}