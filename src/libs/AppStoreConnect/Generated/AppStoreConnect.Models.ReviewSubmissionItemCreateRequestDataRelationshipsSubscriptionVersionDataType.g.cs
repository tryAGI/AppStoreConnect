
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}