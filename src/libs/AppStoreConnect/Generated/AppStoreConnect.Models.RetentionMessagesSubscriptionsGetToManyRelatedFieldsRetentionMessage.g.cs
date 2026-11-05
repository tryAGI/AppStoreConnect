
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage.ReferenceName => "referenceName",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage.Subscriptions => "subscriptions",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage.ReferenceName,
                "subscriptions" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage.Subscriptions,
                "versions" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}