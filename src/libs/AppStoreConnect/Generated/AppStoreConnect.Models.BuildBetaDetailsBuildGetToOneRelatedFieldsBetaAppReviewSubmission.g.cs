
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission.BetaReviewState => "betaReviewState",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission.Build => "build",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "betaReviewState" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission.BetaReviewState,
                "build" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission.Build,
                "submittedDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}