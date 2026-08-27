
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupVersions" => ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType.SubscriptionGroupVersions,
                _ => null,
            };
        }
    }
}