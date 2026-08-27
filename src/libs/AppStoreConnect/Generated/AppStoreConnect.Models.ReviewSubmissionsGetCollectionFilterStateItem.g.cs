
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetCollectionFilterStateItem
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
    public static class ReviewSubmissionsGetCollectionFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionFilterStateItem value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionFilterStateItem.Canceling => "CANCELING",
                ReviewSubmissionsGetCollectionFilterStateItem.Complete => "COMPLETE",
                ReviewSubmissionsGetCollectionFilterStateItem.Completing => "COMPLETING",
                ReviewSubmissionsGetCollectionFilterStateItem.InReview => "IN_REVIEW",
                ReviewSubmissionsGetCollectionFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                ReviewSubmissionsGetCollectionFilterStateItem.UnresolvedIssues => "UNRESOLVED_ISSUES",
                ReviewSubmissionsGetCollectionFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "CANCELING" => ReviewSubmissionsGetCollectionFilterStateItem.Canceling,
                "COMPLETE" => ReviewSubmissionsGetCollectionFilterStateItem.Complete,
                "COMPLETING" => ReviewSubmissionsGetCollectionFilterStateItem.Completing,
                "IN_REVIEW" => ReviewSubmissionsGetCollectionFilterStateItem.InReview,
                "READY_FOR_REVIEW" => ReviewSubmissionsGetCollectionFilterStateItem.ReadyForReview,
                "UNRESOLVED_ISSUES" => ReviewSubmissionsGetCollectionFilterStateItem.UnresolvedIssues,
                "WAITING_FOR_REVIEW" => ReviewSubmissionsGetCollectionFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}