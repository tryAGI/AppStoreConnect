
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupSubscriptionsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupSubscriptionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupSubscriptionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionGroupSubscriptionsLinkagesResponseDataItemType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupSubscriptionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionGroupSubscriptionsLinkagesResponseDataItemType.Subscriptions,
                _ => null,
            };
        }
    }
}