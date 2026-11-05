
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage
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
    public static class AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage value)
        {
            return value switch
            {
                AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage.ReferenceName => "referenceName",
                AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage.Subscriptions => "subscriptions",
                AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage.ReferenceName,
                "subscriptions" => AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage.Subscriptions,
                "versions" => AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}