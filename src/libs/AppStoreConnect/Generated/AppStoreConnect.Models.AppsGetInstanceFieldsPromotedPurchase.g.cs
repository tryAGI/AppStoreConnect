
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsPromotedPurchase
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
    public static class AppsGetInstanceFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsPromotedPurchase value)
        {
            return value switch
            {
                AppsGetInstanceFieldsPromotedPurchase.Enabled => "enabled",
                AppsGetInstanceFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsGetInstanceFieldsPromotedPurchase.State => "state",
                AppsGetInstanceFieldsPromotedPurchase.Subscription => "subscription",
                AppsGetInstanceFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => AppsGetInstanceFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => AppsGetInstanceFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => AppsGetInstanceFieldsPromotedPurchase.State,
                "subscription" => AppsGetInstanceFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => AppsGetInstanceFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}