
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageGetToOneRelatedIncludeItem
    {
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
    public static class SubscriptionsRetentionMessageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageGetToOneRelatedIncludeItem.Subscriptions => "subscriptions",
                SubscriptionsRetentionMessageGetToOneRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionsRetentionMessageGetToOneRelatedIncludeItem.Subscriptions,
                "versions" => SubscriptionsRetentionMessageGetToOneRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}