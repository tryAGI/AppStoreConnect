
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsReviewSubmission
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
    public static class AppsGetCollectionFieldsReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsReviewSubmission value)
        {
            return value switch
            {
                AppsGetCollectionFieldsReviewSubmission.App => "app",
                AppsGetCollectionFieldsReviewSubmission.AppStoreVersionForReview => "appStoreVersionForReview",
                AppsGetCollectionFieldsReviewSubmission.Items => "items",
                AppsGetCollectionFieldsReviewSubmission.LastUpdatedByActor => "lastUpdatedByActor",
                AppsGetCollectionFieldsReviewSubmission.Platform => "platform",
                AppsGetCollectionFieldsReviewSubmission.State => "state",
                AppsGetCollectionFieldsReviewSubmission.SubmittedByActor => "submittedByActor",
                AppsGetCollectionFieldsReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsReviewSubmission.App,
                "appStoreVersionForReview" => AppsGetCollectionFieldsReviewSubmission.AppStoreVersionForReview,
                "items" => AppsGetCollectionFieldsReviewSubmission.Items,
                "lastUpdatedByActor" => AppsGetCollectionFieldsReviewSubmission.LastUpdatedByActor,
                "platform" => AppsGetCollectionFieldsReviewSubmission.Platform,
                "state" => AppsGetCollectionFieldsReviewSubmission.State,
                "submittedByActor" => AppsGetCollectionFieldsReviewSubmission.SubmittedByActor,
                "submittedDate" => AppsGetCollectionFieldsReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}