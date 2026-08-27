
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseState
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
        ProcessingContent,
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
        /// <summary>
        /// 
        /// </summary>
        WaitingForUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseState value)
        {
            return value switch
            {
                InAppPurchaseState.Approved => "APPROVED",
                InAppPurchaseState.DeveloperActionNeeded => "DEVELOPER_ACTION_NEEDED",
                InAppPurchaseState.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                InAppPurchaseState.InReview => "IN_REVIEW",
                InAppPurchaseState.MissingMetadata => "MISSING_METADATA",
                InAppPurchaseState.PendingBinaryApproval => "PENDING_BINARY_APPROVAL",
                InAppPurchaseState.ProcessingContent => "PROCESSING_CONTENT",
                InAppPurchaseState.ReadyToSubmit => "READY_TO_SUBMIT",
                InAppPurchaseState.Rejected => "REJECTED",
                InAppPurchaseState.RemovedFromSale => "REMOVED_FROM_SALE",
                InAppPurchaseState.WaitingForReview => "WAITING_FOR_REVIEW",
                InAppPurchaseState.WaitingForUpload => "WAITING_FOR_UPLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => InAppPurchaseState.Approved,
                "DEVELOPER_ACTION_NEEDED" => InAppPurchaseState.DeveloperActionNeeded,
                "DEVELOPER_REMOVED_FROM_SALE" => InAppPurchaseState.DeveloperRemovedFromSale,
                "IN_REVIEW" => InAppPurchaseState.InReview,
                "MISSING_METADATA" => InAppPurchaseState.MissingMetadata,
                "PENDING_BINARY_APPROVAL" => InAppPurchaseState.PendingBinaryApproval,
                "PROCESSING_CONTENT" => InAppPurchaseState.ProcessingContent,
                "READY_TO_SUBMIT" => InAppPurchaseState.ReadyToSubmit,
                "REJECTED" => InAppPurchaseState.Rejected,
                "REMOVED_FROM_SALE" => InAppPurchaseState.RemovedFromSale,
                "WAITING_FOR_REVIEW" => InAppPurchaseState.WaitingForReview,
                "WAITING_FOR_UPLOAD" => InAppPurchaseState.WaitingForUpload,
                _ => null,
            };
        }
    }
}