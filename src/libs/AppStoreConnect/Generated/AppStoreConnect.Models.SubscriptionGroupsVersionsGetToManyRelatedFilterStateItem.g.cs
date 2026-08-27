
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem
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
    public static class SubscriptionGroupsVersionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.DeveloperRejected => "DEVELOPER_REJECTED",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.Approved,
                "DEVELOPER_REJECTED" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.DeveloperRejected,
                "IN_REVIEW" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.Rejected,
                "REPLACED_WITH_NEW_VERSION" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}