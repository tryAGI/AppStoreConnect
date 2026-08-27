
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        BetaReviewState,
        /// <summary>
        /// 
        /// </summary>
        Build,
        /// <summary>
        /// 
        /// </summary>
        SubmittedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission.BetaReviewState => "betaReviewState",
                BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission.Build => "build",
                BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "betaReviewState" => BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission.BetaReviewState,
                "build" => BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission.Build,
                "submittedDate" => BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}