
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem
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
    public static class BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.Approved => "APPROVED",
                BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.InReview => "IN_REVIEW",
                BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.Rejected => "REJECTED",
                BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.Approved,
                "IN_REVIEW" => BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.InReview,
                "REJECTED" => BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.Rejected,
                "WAITING_FOR_REVIEW" => BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}