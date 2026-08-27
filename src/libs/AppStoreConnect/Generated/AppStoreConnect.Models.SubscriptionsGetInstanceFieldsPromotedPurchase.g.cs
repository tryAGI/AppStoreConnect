
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsPromotedPurchase
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
    public static class SubscriptionsGetInstanceFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsPromotedPurchase value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsPromotedPurchase.Enabled => "enabled",
                SubscriptionsGetInstanceFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                SubscriptionsGetInstanceFieldsPromotedPurchase.State => "state",
                SubscriptionsGetInstanceFieldsPromotedPurchase.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SubscriptionsGetInstanceFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => SubscriptionsGetInstanceFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => SubscriptionsGetInstanceFieldsPromotedPurchase.State,
                "subscription" => SubscriptionsGetInstanceFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => SubscriptionsGetInstanceFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}