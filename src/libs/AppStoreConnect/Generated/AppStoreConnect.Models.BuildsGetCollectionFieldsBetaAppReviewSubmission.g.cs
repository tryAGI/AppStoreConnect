
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsBetaAppReviewSubmission
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
    public static class BuildsGetCollectionFieldsBetaAppReviewSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBetaAppReviewSubmission value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBetaAppReviewSubmission.BetaReviewState => "betaReviewState",
                BuildsGetCollectionFieldsBetaAppReviewSubmission.Build => "build",
                BuildsGetCollectionFieldsBetaAppReviewSubmission.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBetaAppReviewSubmission? ToEnum(string value)
        {
            return value switch
            {
                "betaReviewState" => BuildsGetCollectionFieldsBetaAppReviewSubmission.BetaReviewState,
                "build" => BuildsGetCollectionFieldsBetaAppReviewSubmission.Build,
                "submittedDate" => BuildsGetCollectionFieldsBetaAppReviewSubmission.SubmittedDate,
                _ => null,
            };
        }
    }
}