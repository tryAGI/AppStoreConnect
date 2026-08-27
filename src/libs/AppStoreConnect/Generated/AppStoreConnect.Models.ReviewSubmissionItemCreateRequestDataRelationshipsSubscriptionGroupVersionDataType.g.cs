
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType.SubscriptionGroupVersions,
                _ => null,
            };
        }
    }
}