
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType value)
        {
            return value switch
            {
                ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}