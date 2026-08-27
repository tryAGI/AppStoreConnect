
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup
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
    public static class SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.ReferenceName => "referenceName",
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.Subscriptions,
                "versions" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}