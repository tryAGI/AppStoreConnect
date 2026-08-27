
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName => "referenceName",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions,
                "versions" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}