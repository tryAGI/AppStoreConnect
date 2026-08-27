
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsGetCollectionFieldsReviewSubmission
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionForReview,
        /// <summary>
        ///
        /// </summary>
        Items,
        /// <summary>
        ///
        /// </summary>
        LastUpdatedByActor,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        SubmittedByActor,
        /// <summary>
        ///
        /// </summary>
        SubmittedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsGetCollectionFieldsReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionFieldsReviewSubmission value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.App => "app",
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.AppStoreVersionForReview => "appStoreVersionForReview",
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.Items => "items",
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.LastUpdatedByActor => "lastUpdatedByActor",
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.Platform => "platform",
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.State => "state",
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.SubmittedByActor => "submittedByActor",
                ReviewSubmissionsGetCollectionFieldsReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionFieldsReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "app" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.App,
                "appStoreVersionForReview" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.AppStoreVersionForReview,
                "items" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.Items,
                "lastUpdatedByActor" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.LastUpdatedByActor,
                "platform" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.Platform,
                "state" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.State,
                "submittedByActor" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.SubmittedByActor,
                "submittedDate" => ReviewSubmissionsGetCollectionFieldsReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}