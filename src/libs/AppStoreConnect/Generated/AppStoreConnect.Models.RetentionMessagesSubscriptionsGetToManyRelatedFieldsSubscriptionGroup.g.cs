
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup
    {
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName => "referenceName",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions,
                "versions" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}