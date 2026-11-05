
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsRetentionMessagesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsRetentionMessagesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsRetentionMessagesDataItemType value)
        {
            return value switch
            {
                AppRelationshipsRetentionMessagesDataItemType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsRetentionMessagesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessages" => AppRelationshipsRetentionMessagesDataItemType.RetentionMessages,
                _ => null,
            };
        }
    }
}