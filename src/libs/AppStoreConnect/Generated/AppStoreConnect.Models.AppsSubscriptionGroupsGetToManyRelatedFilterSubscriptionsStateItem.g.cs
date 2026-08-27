
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        DeveloperActionNeeded,
        /// <summary>
        /// 
        /// </summary>
        DeveloperRemovedFromSale,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        MissingMetadata,
        /// <summary>
        /// 
        /// </summary>
        PendingBinaryApproval,
        /// <summary>
        /// 
        /// </summary>
        ReadyToSubmit,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        RemovedFromSale,
        /// <summary>
        /// 
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem value)
        {
            return value switch
            {
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.Approved => "APPROVED",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.DeveloperActionNeeded => "DEVELOPER_ACTION_NEEDED",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.InReview => "IN_REVIEW",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.MissingMetadata => "MISSING_METADATA",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.PendingBinaryApproval => "PENDING_BINARY_APPROVAL",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.ReadyToSubmit => "READY_TO_SUBMIT",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.Rejected => "REJECTED",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.RemovedFromSale => "REMOVED_FROM_SALE",
                AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.Approved,
                "DEVELOPER_ACTION_NEEDED" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.DeveloperActionNeeded,
                "DEVELOPER_REMOVED_FROM_SALE" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.DeveloperRemovedFromSale,
                "IN_REVIEW" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.InReview,
                "MISSING_METADATA" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.MissingMetadata,
                "PENDING_BINARY_APPROVAL" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.PendingBinaryApproval,
                "READY_TO_SUBMIT" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.ReadyToSubmit,
                "REJECTED" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.Rejected,
                "REMOVED_FROM_SALE" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.RemovedFromSale,
                "WAITING_FOR_REVIEW" => AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}