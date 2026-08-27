
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsVersionsGetToManyRelatedFilterStateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        DeveloperRejected,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        PrepareForSubmission,
        /// <summary>
        /// 
        /// </summary>
        ReadyForReview,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        ReplacedWithNewVersion,
        /// <summary>
        /// 
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsVersionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsVersionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.DeveloperRejected => "DEVELOPER_REJECTED",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                SubscriptionsVersionsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsVersionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.Approved,
                "DEVELOPER_REJECTED" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.DeveloperRejected,
                "IN_REVIEW" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.Rejected,
                "REPLACED_WITH_NEW_VERSION" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => SubscriptionsVersionsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}