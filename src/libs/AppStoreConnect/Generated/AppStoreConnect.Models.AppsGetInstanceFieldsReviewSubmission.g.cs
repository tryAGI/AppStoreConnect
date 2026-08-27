
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsReviewSubmission
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
    public static class AppsGetInstanceFieldsReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsReviewSubmission value)
        {
            return value switch
            {
                AppsGetInstanceFieldsReviewSubmission.App => "app",
                AppsGetInstanceFieldsReviewSubmission.AppStoreVersionForReview => "appStoreVersionForReview",
                AppsGetInstanceFieldsReviewSubmission.Items => "items",
                AppsGetInstanceFieldsReviewSubmission.LastUpdatedByActor => "lastUpdatedByActor",
                AppsGetInstanceFieldsReviewSubmission.Platform => "platform",
                AppsGetInstanceFieldsReviewSubmission.State => "state",
                AppsGetInstanceFieldsReviewSubmission.SubmittedByActor => "submittedByActor",
                AppsGetInstanceFieldsReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsReviewSubmission.App,
                "appStoreVersionForReview" => AppsGetInstanceFieldsReviewSubmission.AppStoreVersionForReview,
                "items" => AppsGetInstanceFieldsReviewSubmission.Items,
                "lastUpdatedByActor" => AppsGetInstanceFieldsReviewSubmission.LastUpdatedByActor,
                "platform" => AppsGetInstanceFieldsReviewSubmission.Platform,
                "state" => AppsGetInstanceFieldsReviewSubmission.State,
                "submittedByActor" => AppsGetInstanceFieldsReviewSubmission.SubmittedByActor,
                "submittedDate" => AppsGetInstanceFieldsReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}