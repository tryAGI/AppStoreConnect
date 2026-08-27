
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission.BetaReviewState => "betaReviewState",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission.Build => "build",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "betaReviewState" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission.BetaReviewState,
                "build" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission.Build,
                "submittedDate" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}