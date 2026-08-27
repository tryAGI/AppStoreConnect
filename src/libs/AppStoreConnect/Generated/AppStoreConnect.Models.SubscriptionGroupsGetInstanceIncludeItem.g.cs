
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsGetInstanceIncludeItem
    {
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
    public static class SubscriptionGroupsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupsGetInstanceIncludeItem.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupsGetInstanceIncludeItem.Subscriptions => "subscriptions",
                SubscriptionGroupsGetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupsGetInstanceIncludeItem.SubscriptionGroupLocalizations,
                "subscriptions" => SubscriptionGroupsGetInstanceIncludeItem.Subscriptions,
                "versions" => SubscriptionGroupsGetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}