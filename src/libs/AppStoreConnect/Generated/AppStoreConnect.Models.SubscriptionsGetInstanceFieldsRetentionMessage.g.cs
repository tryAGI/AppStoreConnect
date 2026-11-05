
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsRetentionMessage
    {
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
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
    public static class SubscriptionsGetInstanceFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsRetentionMessage value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsRetentionMessage.ReferenceName => "referenceName",
                SubscriptionsGetInstanceFieldsRetentionMessage.Subscriptions => "subscriptions",
                SubscriptionsGetInstanceFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionsGetInstanceFieldsRetentionMessage.ReferenceName,
                "subscriptions" => SubscriptionsGetInstanceFieldsRetentionMessage.Subscriptions,
                "versions" => SubscriptionsGetInstanceFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}