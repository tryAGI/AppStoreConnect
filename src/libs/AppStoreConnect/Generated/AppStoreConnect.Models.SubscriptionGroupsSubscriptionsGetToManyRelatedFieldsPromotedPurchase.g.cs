
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Enabled => "enabled",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.State => "state",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Subscription => "subscription",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.State,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}