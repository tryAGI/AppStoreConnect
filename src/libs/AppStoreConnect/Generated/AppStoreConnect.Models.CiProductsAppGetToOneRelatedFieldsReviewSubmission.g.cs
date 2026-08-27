
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsReviewSubmission
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
    public static class CiProductsAppGetToOneRelatedFieldsReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsReviewSubmission value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.App => "app",
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.AppStoreVersionForReview => "appStoreVersionForReview",
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.Items => "items",
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.LastUpdatedByActor => "lastUpdatedByActor",
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.Platform => "platform",
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.State => "state",
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.SubmittedByActor => "submittedByActor",
                CiProductsAppGetToOneRelatedFieldsReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.App,
                "appStoreVersionForReview" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.AppStoreVersionForReview,
                "items" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.Items,
                "lastUpdatedByActor" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.LastUpdatedByActor,
                "platform" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.Platform,
                "state" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.State,
                "submittedByActor" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.SubmittedByActor,
                "submittedDate" => CiProductsAppGetToOneRelatedFieldsReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}