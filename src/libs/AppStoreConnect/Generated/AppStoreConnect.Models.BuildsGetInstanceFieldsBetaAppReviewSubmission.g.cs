
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsBetaAppReviewSubmission
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
    public static class BuildsGetInstanceFieldsBetaAppReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBetaAppReviewSubmission value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBetaAppReviewSubmission.BetaReviewState => "betaReviewState",
                BuildsGetInstanceFieldsBetaAppReviewSubmission.Build => "build",
                BuildsGetInstanceFieldsBetaAppReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBetaAppReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "betaReviewState" => BuildsGetInstanceFieldsBetaAppReviewSubmission.BetaReviewState,
                "build" => BuildsGetInstanceFieldsBetaAppReviewSubmission.Build,
                "submittedDate" => BuildsGetInstanceFieldsBetaAppReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}