
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsSubscriptionGroup
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
    public static class AppsGetInstanceFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsSubscriptionGroup value)
        {
            return value switch
            {
                AppsGetInstanceFieldsSubscriptionGroup.ReferenceName => "referenceName",
                AppsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                AppsGetInstanceFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                AppsGetInstanceFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => AppsGetInstanceFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => AppsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => AppsGetInstanceFieldsSubscriptionGroup.Subscriptions,
                "versions" => AppsGetInstanceFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}