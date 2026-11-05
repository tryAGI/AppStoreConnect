
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage
    {
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage.ReferenceName => "referenceName",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage.Subscriptions => "subscriptions",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage.ReferenceName,
                "subscriptions" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage.Subscriptions,
                "versions" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}