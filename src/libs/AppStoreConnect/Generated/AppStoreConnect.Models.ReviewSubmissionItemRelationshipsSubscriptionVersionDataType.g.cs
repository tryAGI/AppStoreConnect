
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsSubscriptionVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsSubscriptionVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsSubscriptionVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsSubscriptionVersionDataType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsSubscriptionVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionVersions" => ReviewSubmissionItemRelationshipsSubscriptionVersionDataType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}