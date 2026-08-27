
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsSubscriptionGroupsGetToManyRelatedIncludeItem
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
    public static class AppsSubscriptionGroupsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGroupsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsSubscriptionGroupsGetToManyRelatedIncludeItem.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                AppsSubscriptionGroupsGetToManyRelatedIncludeItem.Subscriptions => "subscriptions",
                AppsSubscriptionGroupsGetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGroupsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => AppsSubscriptionGroupsGetToManyRelatedIncludeItem.SubscriptionGroupLocalizations,
                "subscriptions" => AppsSubscriptionGroupsGetToManyRelatedIncludeItem.Subscriptions,
                "versions" => AppsSubscriptionGroupsGetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}