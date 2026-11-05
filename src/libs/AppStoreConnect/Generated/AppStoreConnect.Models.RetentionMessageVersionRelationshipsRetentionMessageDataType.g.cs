
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionRelationshipsRetentionMessageDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionRelationshipsRetentionMessageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionRelationshipsRetentionMessageDataType value)
        {
            return value switch
            {
                RetentionMessageVersionRelationshipsRetentionMessageDataType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionRelationshipsRetentionMessageDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessages" => RetentionMessageVersionRelationshipsRetentionMessageDataType.RetentionMessages,
                _ => null,
            };
        }
    }
}