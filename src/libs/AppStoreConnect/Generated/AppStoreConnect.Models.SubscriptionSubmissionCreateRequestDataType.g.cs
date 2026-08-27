
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionSubmissionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionSubmissionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionSubmissionCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionSubmissionCreateRequestDataType.SubscriptionSubmissions => "subscriptionSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionSubmissionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionSubmissions" => SubscriptionSubmissionCreateRequestDataType.SubscriptionSubmissions,
                _ => null,
            };
        }
    }
}