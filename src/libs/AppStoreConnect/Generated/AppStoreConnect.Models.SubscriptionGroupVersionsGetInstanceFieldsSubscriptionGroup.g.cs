
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup
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
    public static class SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup value)
        {
            return value switch
            {
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.ReferenceName => "referenceName",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.Subscriptions,
                "versions" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}