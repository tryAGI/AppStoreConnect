
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsGetInstanceFieldsSubscriptionGroup
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
    public static class SubscriptionGroupsGetInstanceFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsGetInstanceFieldsSubscriptionGroup value)
        {
            return value switch
            {
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.ReferenceName => "referenceName",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsGetInstanceFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.Subscriptions,
                "versions" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}