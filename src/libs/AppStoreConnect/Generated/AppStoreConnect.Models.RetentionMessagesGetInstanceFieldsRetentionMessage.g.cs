
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesGetInstanceFieldsRetentionMessage
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
    public static class RetentionMessagesGetInstanceFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesGetInstanceFieldsRetentionMessage value)
        {
            return value switch
            {
                RetentionMessagesGetInstanceFieldsRetentionMessage.ReferenceName => "referenceName",
                RetentionMessagesGetInstanceFieldsRetentionMessage.Subscriptions => "subscriptions",
                RetentionMessagesGetInstanceFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesGetInstanceFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => RetentionMessagesGetInstanceFieldsRetentionMessage.ReferenceName,
                "subscriptions" => RetentionMessagesGetInstanceFieldsRetentionMessage.Subscriptions,
                "versions" => RetentionMessagesGetInstanceFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}