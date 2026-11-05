
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionUpdateRequestDataRelationshipsRetentionMessageDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionUpdateRequestDataRelationshipsRetentionMessageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionUpdateRequestDataRelationshipsRetentionMessageDataType value)
        {
            return value switch
            {
                SubscriptionUpdateRequestDataRelationshipsRetentionMessageDataType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionUpdateRequestDataRelationshipsRetentionMessageDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessages" => SubscriptionUpdateRequestDataRelationshipsRetentionMessageDataType.RetentionMessages,
                _ => null,
            };
        }
    }
}