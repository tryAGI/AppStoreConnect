
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaReviewState
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
    public static class BetaReviewStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReviewState value)
        {
            return value switch
            {
                BetaReviewState.Approved => "APPROVED",
                BetaReviewState.InReview => "IN_REVIEW",
                BetaReviewState.Rejected => "REJECTED",
                BetaReviewState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReviewState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => BetaReviewState.Approved,
                "IN_REVIEW" => BetaReviewState.InReview,
                "REJECTED" => BetaReviewState.Rejected,
                "WAITING_FOR_REVIEW" => BetaReviewState.WaitingForReview,
                _ => null,
            };
        }
    }
}