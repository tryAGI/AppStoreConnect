
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.DeveloperActionNeeded => "DEVELOPER_ACTION_NEEDED",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.MissingMetadata => "MISSING_METADATA",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.PendingBinaryApproval => "PENDING_BINARY_APPROVAL",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.ReadyToSubmit => "READY_TO_SUBMIT",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.RemovedFromSale => "REMOVED_FROM_SALE",
                RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.Approved,
                "DEVELOPER_ACTION_NEEDED" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.DeveloperActionNeeded,
                "DEVELOPER_REMOVED_FROM_SALE" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.DeveloperRemovedFromSale,
                "IN_REVIEW" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.InReview,
                "MISSING_METADATA" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.MissingMetadata,
                "PENDING_BINARY_APPROVAL" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.PendingBinaryApproval,
                "READY_TO_SUBMIT" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.ReadyToSubmit,
                "REJECTED" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.Rejected,
                "REMOVED_FROM_SALE" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.RemovedFromSale,
                "WAITING_FOR_REVIEW" => RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}