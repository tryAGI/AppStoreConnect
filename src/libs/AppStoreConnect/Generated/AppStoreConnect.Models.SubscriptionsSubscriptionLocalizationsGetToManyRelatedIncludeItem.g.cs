
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscription" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}