
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRetentionMessageLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRetentionMessageLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRetentionMessageLinkageRequestDataType value)
        {
            return value switch
            {
                SubscriptionRetentionMessageLinkageRequestDataType.RetentionMessages => "retentionMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRetentionMessageLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessages" => SubscriptionRetentionMessageLinkageRequestDataType.RetentionMessages,
                _ => null,
            };
        }
    }
}