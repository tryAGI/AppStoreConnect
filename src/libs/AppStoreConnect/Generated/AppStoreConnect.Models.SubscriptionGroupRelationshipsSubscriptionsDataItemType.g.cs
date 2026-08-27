
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupRelationshipsSubscriptionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupRelationshipsSubscriptionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupRelationshipsSubscriptionsDataItemType value)
        {
            return value switch
            {
                SubscriptionGroupRelationshipsSubscriptionsDataItemType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupRelationshipsSubscriptionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionGroupRelationshipsSubscriptionsDataItemType.Subscriptions,
                _ => null,
            };
        }
    }
}