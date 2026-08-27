
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionAttributesState
    {
        /// <summary>
        ///
        /// </summary>
        Canceling,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Completing,
        /// <summary>
        ///
        /// </summary>
        InReview,
        /// <summary>
        ///
        /// </summary>
        ReadyForReview,
        /// <summary>
        ///
        /// </summary>
        UnresolvedIssues,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionAttributesState value)
        {
            return value switch
            {
                ReviewSubmissionAttributesState.Canceling => "CANCELING",
                ReviewSubmissionAttributesState.Complete => "COMPLETE",
                ReviewSubmissionAttributesState.Completing => "COMPLETING",
                ReviewSubmissionAttributesState.InReview => "IN_REVIEW",
                ReviewSubmissionAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                ReviewSubmissionAttributesState.UnresolvedIssues => "UNRESOLVED_ISSUES",
                ReviewSubmissionAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "CANCELING" => ReviewSubmissionAttributesState.Canceling,
                "COMPLETE" => ReviewSubmissionAttributesState.Complete,
                "COMPLETING" => ReviewSubmissionAttributesState.Completing,
                "IN_REVIEW" => ReviewSubmissionAttributesState.InReview,
                "READY_FOR_REVIEW" => ReviewSubmissionAttributesState.ReadyForReview,
                "UNRESOLVED_ISSUES" => ReviewSubmissionAttributesState.UnresolvedIssues,
                "WAITING_FOR_REVIEW" => ReviewSubmissionAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}