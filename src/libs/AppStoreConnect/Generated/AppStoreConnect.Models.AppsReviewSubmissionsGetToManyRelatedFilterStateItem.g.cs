
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsReviewSubmissionsGetToManyRelatedFilterStateItem
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
    public static class AppsReviewSubmissionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsReviewSubmissionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppsReviewSubmissionsGetToManyRelatedFilterStateItem.Canceling => "CANCELING",
                AppsReviewSubmissionsGetToManyRelatedFilterStateItem.Complete => "COMPLETE",
                AppsReviewSubmissionsGetToManyRelatedFilterStateItem.Completing => "COMPLETING",
                AppsReviewSubmissionsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppsReviewSubmissionsGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsReviewSubmissionsGetToManyRelatedFilterStateItem.UnresolvedIssues => "UNRESOLVED_ISSUES",
                AppsReviewSubmissionsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsReviewSubmissionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "CANCELING" => AppsReviewSubmissionsGetToManyRelatedFilterStateItem.Canceling,
                "COMPLETE" => AppsReviewSubmissionsGetToManyRelatedFilterStateItem.Complete,
                "COMPLETING" => AppsReviewSubmissionsGetToManyRelatedFilterStateItem.Completing,
                "IN_REVIEW" => AppsReviewSubmissionsGetToManyRelatedFilterStateItem.InReview,
                "READY_FOR_REVIEW" => AppsReviewSubmissionsGetToManyRelatedFilterStateItem.ReadyForReview,
                "UNRESOLVED_ISSUES" => AppsReviewSubmissionsGetToManyRelatedFilterStateItem.UnresolvedIssues,
                "WAITING_FOR_REVIEW" => AppsReviewSubmissionsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}