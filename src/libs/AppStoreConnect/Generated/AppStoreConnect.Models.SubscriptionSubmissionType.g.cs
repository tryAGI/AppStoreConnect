
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionSubmissionType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionSubmissionType value)
        {
            return value switch
            {
                SubscriptionSubmissionType.SubscriptionSubmissions => "subscriptionSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionSubmissions" => SubscriptionSubmissionType.SubscriptionSubmissions,
                _ => null,
            };
        }
    }
}