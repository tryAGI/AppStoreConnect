
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem
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
    public static class BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem value)
        {
            return value switch
            {
                BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.Approved => "APPROVED",
                BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.InReview => "IN_REVIEW",
                BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.Rejected => "REJECTED",
                BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.Approved,
                "IN_REVIEW" => BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.InReview,
                "REJECTED" => BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.Rejected,
                "WAITING_FOR_REVIEW" => BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}