
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Enabled => "enabled",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.State => "state",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.State,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}