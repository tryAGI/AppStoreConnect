
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission
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
    public static class BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission.BetaReviewState => "betaReviewState",
                BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission.Build => "build",
                BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "betaReviewState" => BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission.BetaReviewState,
                "build" => BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission.Build,
                "submittedDate" => BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}