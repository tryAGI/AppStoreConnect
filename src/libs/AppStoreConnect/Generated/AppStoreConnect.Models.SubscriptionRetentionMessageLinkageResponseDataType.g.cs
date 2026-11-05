
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRetentionMessageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRetentionMessageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRetentionMessageLinkageResponseDataType value)
        {
            return value switch
            {
                SubscriptionRetentionMessageLinkageResponseDataType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRetentionMessageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessages" => SubscriptionRetentionMessageLinkageResponseDataType.RetentionMessages,
                _ => null,
            };
        }
    }
}