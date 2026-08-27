
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFilterReviewSubmissionsStateItem
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
    public static class AppsGetCollectionFilterReviewSubmissionsStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFilterReviewSubmissionsStateItem value)
        {
            return value switch
            {
                AppsGetCollectionFilterReviewSubmissionsStateItem.Canceling => "CANCELING",
                AppsGetCollectionFilterReviewSubmissionsStateItem.Complete => "COMPLETE",
                AppsGetCollectionFilterReviewSubmissionsStateItem.Completing => "COMPLETING",
                AppsGetCollectionFilterReviewSubmissionsStateItem.InReview => "IN_REVIEW",
                AppsGetCollectionFilterReviewSubmissionsStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsGetCollectionFilterReviewSubmissionsStateItem.UnresolvedIssues => "UNRESOLVED_ISSUES",
                AppsGetCollectionFilterReviewSubmissionsStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFilterReviewSubmissionsStateItem? ToEnum(string value)
        {
            return value switch
            {
                "CANCELING" => AppsGetCollectionFilterReviewSubmissionsStateItem.Canceling,
                "COMPLETE" => AppsGetCollectionFilterReviewSubmissionsStateItem.Complete,
                "COMPLETING" => AppsGetCollectionFilterReviewSubmissionsStateItem.Completing,
                "IN_REVIEW" => AppsGetCollectionFilterReviewSubmissionsStateItem.InReview,
                "READY_FOR_REVIEW" => AppsGetCollectionFilterReviewSubmissionsStateItem.ReadyForReview,
                "UNRESOLVED_ISSUES" => AppsGetCollectionFilterReviewSubmissionsStateItem.UnresolvedIssues,
                "WAITING_FOR_REVIEW" => AppsGetCollectionFilterReviewSubmissionsStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}