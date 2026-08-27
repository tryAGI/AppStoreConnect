
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission
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
    public static class AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission value)
        {
            return value switch
            {
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.App => "app",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.AppStoreVersionForReview => "appStoreVersionForReview",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.Items => "items",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.LastUpdatedByActor => "lastUpdatedByActor",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.Platform => "platform",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.State => "state",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.SubmittedByActor => "submittedByActor",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.App,
                "appStoreVersionForReview" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.AppStoreVersionForReview,
                "items" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.Items,
                "lastUpdatedByActor" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.LastUpdatedByActor,
                "platform" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.Platform,
                "state" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.State,
                "submittedByActor" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.SubmittedByActor,
                "submittedDate" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}