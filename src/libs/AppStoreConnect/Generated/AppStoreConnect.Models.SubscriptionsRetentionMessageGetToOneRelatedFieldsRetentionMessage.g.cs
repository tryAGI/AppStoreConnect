
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage
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
    public static class SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage.ReferenceName => "referenceName",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage.Subscriptions => "subscriptions",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage.ReferenceName,
                "subscriptions" => SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage.Subscriptions,
                "versions" => SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}