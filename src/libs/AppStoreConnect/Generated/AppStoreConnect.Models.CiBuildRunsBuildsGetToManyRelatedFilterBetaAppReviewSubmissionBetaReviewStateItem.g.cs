
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        InReview,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.Approved => "APPROVED",
                CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.InReview => "IN_REVIEW",
                CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.Rejected => "REJECTED",
                CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.Approved,
                "IN_REVIEW" => CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.InReview,
                "REJECTED" => CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.Rejected,
                "WAITING_FOR_REVIEW" => CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}