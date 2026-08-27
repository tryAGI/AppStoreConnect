
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase
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
    public static class SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase value)
        {
            return value switch
            {
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Enabled => "enabled",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.State => "state",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Subscription => "subscription",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.State,
                "subscription" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}