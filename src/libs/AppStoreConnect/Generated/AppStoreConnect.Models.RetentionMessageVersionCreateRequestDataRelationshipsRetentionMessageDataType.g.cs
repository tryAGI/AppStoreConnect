
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessageDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessageDataType value)
        {
            return value switch
            {
                RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessageDataType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessageDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessages" => RetentionMessageVersionCreateRequestDataRelationshipsRetentionMessageDataType.RetentionMessages,
                _ => null,
            };
        }
    }
}