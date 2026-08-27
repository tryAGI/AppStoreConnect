
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType.ReviewSubmissions => "reviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissions" => ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType.ReviewSubmissions,
                _ => null,
            };
        }
    }
}