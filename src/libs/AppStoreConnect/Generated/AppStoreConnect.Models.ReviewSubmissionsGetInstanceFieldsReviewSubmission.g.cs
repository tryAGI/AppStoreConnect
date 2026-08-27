
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsGetInstanceFieldsReviewSubmission
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
    public static class ReviewSubmissionsGetInstanceFieldsReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetInstanceFieldsReviewSubmission value)
        {
            return value switch
            {
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.App => "app",
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.AppStoreVersionForReview => "appStoreVersionForReview",
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.Items => "items",
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.LastUpdatedByActor => "lastUpdatedByActor",
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.Platform => "platform",
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.State => "state",
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.SubmittedByActor => "submittedByActor",
                ReviewSubmissionsGetInstanceFieldsReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetInstanceFieldsReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "app" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.App,
                "appStoreVersionForReview" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.AppStoreVersionForReview,
                "items" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.Items,
                "lastUpdatedByActor" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.LastUpdatedByActor,
                "platform" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.Platform,
                "state" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.State,
                "submittedByActor" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.SubmittedByActor,
                "submittedDate" => ReviewSubmissionsGetInstanceFieldsReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}