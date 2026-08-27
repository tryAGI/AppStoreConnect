
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission
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
    public static class BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission value)
        {
            return value switch
            {
                BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission.BetaReviewState => "betaReviewState",
                BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission.Build => "build",
                BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "betaReviewState" => BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission.BetaReviewState,
                "build" => BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission.Build,
                "submittedDate" => BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}