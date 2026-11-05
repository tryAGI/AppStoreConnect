
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage
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
    public static class RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage value)
        {
            return value switch
            {
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage.ReferenceName => "referenceName",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage.Subscriptions => "subscriptions",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage.ReferenceName,
                "subscriptions" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage.Subscriptions,
                "versions" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}