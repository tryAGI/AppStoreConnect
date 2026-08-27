
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.DeveloperActionNeeded => "DEVELOPER_ACTION_NEEDED",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.MissingMetadata => "MISSING_METADATA",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.PendingBinaryApproval => "PENDING_BINARY_APPROVAL",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.ReadyToSubmit => "READY_TO_SUBMIT",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.RemovedFromSale => "REMOVED_FROM_SALE",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.Approved,
                "DEVELOPER_ACTION_NEEDED" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.DeveloperActionNeeded,
                "DEVELOPER_REMOVED_FROM_SALE" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.DeveloperRemovedFromSale,
                "IN_REVIEW" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.InReview,
                "MISSING_METADATA" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.MissingMetadata,
                "PENDING_BINARY_APPROVAL" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.PendingBinaryApproval,
                "READY_TO_SUBMIT" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.ReadyToSubmit,
                "REJECTED" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.Rejected,
                "REMOVED_FROM_SALE" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.RemovedFromSale,
                "WAITING_FOR_REVIEW" => SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}