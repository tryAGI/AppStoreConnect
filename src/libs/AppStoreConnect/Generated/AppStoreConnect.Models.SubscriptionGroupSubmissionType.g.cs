
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupSubmissionType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupSubmissionType value)
        {
            return value switch
            {
                SubscriptionGroupSubmissionType.SubscriptionGroupSubmissions => "subscriptionGroupSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupSubmissions" => SubscriptionGroupSubmissionType.SubscriptionGroupSubmissions,
                _ => null,
            };
        }
    }
}