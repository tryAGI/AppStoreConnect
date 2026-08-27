
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAttributesState
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
    public static class SubscriptionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAttributesState value)
        {
            return value switch
            {
                SubscriptionAttributesState.Approved => "APPROVED",
                SubscriptionAttributesState.DeveloperActionNeeded => "DEVELOPER_ACTION_NEEDED",
                SubscriptionAttributesState.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                SubscriptionAttributesState.InReview => "IN_REVIEW",
                SubscriptionAttributesState.MissingMetadata => "MISSING_METADATA",
                SubscriptionAttributesState.PendingBinaryApproval => "PENDING_BINARY_APPROVAL",
                SubscriptionAttributesState.ReadyToSubmit => "READY_TO_SUBMIT",
                SubscriptionAttributesState.Rejected => "REJECTED",
                SubscriptionAttributesState.RemovedFromSale => "REMOVED_FROM_SALE",
                SubscriptionAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => SubscriptionAttributesState.Approved,
                "DEVELOPER_ACTION_NEEDED" => SubscriptionAttributesState.DeveloperActionNeeded,
                "DEVELOPER_REMOVED_FROM_SALE" => SubscriptionAttributesState.DeveloperRemovedFromSale,
                "IN_REVIEW" => SubscriptionAttributesState.InReview,
                "MISSING_METADATA" => SubscriptionAttributesState.MissingMetadata,
                "PENDING_BINARY_APPROVAL" => SubscriptionAttributesState.PendingBinaryApproval,
                "READY_TO_SUBMIT" => SubscriptionAttributesState.ReadyToSubmit,
                "REJECTED" => SubscriptionAttributesState.Rejected,
                "REMOVED_FROM_SALE" => SubscriptionAttributesState.RemovedFromSale,
                "WAITING_FOR_REVIEW" => SubscriptionAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}