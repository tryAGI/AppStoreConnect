
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupSubmissionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupSubmissionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupSubmissionCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGroupSubmissionCreateRequestDataType.SubscriptionGroupSubmissions => "subscriptionGroupSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupSubmissionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupSubmissions" => SubscriptionGroupSubmissionCreateRequestDataType.SubscriptionGroupSubmissions,
                _ => null,
            };
        }
    }
}