
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseAttributesState
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Deleted,
        /// <summary>
        ///
        /// </summary>
        DeletionInProgress,
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
        DeveloperSignedOff,
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
        PendingDeveloperRelease,
        /// <summary>
        ///
        /// </summary>
        PrepareForSubmission,
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
        Replaced,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
        /// <summary>
        ///
        /// </summary>
        WaitingForScreenshot,
        /// <summary>
        ///
        /// </summary>
        WaitingForUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAttributesState value)
        {
            return value switch
            {
                InAppPurchaseAttributesState.Approved => "APPROVED",
                InAppPurchaseAttributesState.Created => "CREATED",
                InAppPurchaseAttributesState.Deleted => "DELETED",
                InAppPurchaseAttributesState.DeletionInProgress => "DELETION_IN_PROGRESS",
                InAppPurchaseAttributesState.DeveloperActionNeeded => "DEVELOPER_ACTION_NEEDED",
                InAppPurchaseAttributesState.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                InAppPurchaseAttributesState.DeveloperSignedOff => "DEVELOPER_SIGNED_OFF",
                InAppPurchaseAttributesState.InReview => "IN_REVIEW",
                InAppPurchaseAttributesState.MissingMetadata => "MISSING_METADATA",
                InAppPurchaseAttributesState.PendingDeveloperRelease => "PENDING_DEVELOPER_RELEASE",
                InAppPurchaseAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                InAppPurchaseAttributesState.ProcessingContent => "PROCESSING_CONTENT",
                InAppPurchaseAttributesState.ReadyToSubmit => "READY_TO_SUBMIT",
                InAppPurchaseAttributesState.Rejected => "REJECTED",
                InAppPurchaseAttributesState.RemovedFromSale => "REMOVED_FROM_SALE",
                InAppPurchaseAttributesState.Replaced => "REPLACED",
                InAppPurchaseAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                InAppPurchaseAttributesState.WaitingForScreenshot => "WAITING_FOR_SCREENSHOT",
                InAppPurchaseAttributesState.WaitingForUpload => "WAITING_FOR_UPLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => InAppPurchaseAttributesState.Approved,
                "CREATED" => InAppPurchaseAttributesState.Created,
                "DELETED" => InAppPurchaseAttributesState.Deleted,
                "DELETION_IN_PROGRESS" => InAppPurchaseAttributesState.DeletionInProgress,
                "DEVELOPER_ACTION_NEEDED" => InAppPurchaseAttributesState.DeveloperActionNeeded,
                "DEVELOPER_REMOVED_FROM_SALE" => InAppPurchaseAttributesState.DeveloperRemovedFromSale,
                "DEVELOPER_SIGNED_OFF" => InAppPurchaseAttributesState.DeveloperSignedOff,
                "IN_REVIEW" => InAppPurchaseAttributesState.InReview,
                "MISSING_METADATA" => InAppPurchaseAttributesState.MissingMetadata,
                "PENDING_DEVELOPER_RELEASE" => InAppPurchaseAttributesState.PendingDeveloperRelease,
                "PREPARE_FOR_SUBMISSION" => InAppPurchaseAttributesState.PrepareForSubmission,
                "PROCESSING_CONTENT" => InAppPurchaseAttributesState.ProcessingContent,
                "READY_TO_SUBMIT" => InAppPurchaseAttributesState.ReadyToSubmit,
                "REJECTED" => InAppPurchaseAttributesState.Rejected,
                "REMOVED_FROM_SALE" => InAppPurchaseAttributesState.RemovedFromSale,
                "REPLACED" => InAppPurchaseAttributesState.Replaced,
                "WAITING_FOR_REVIEW" => InAppPurchaseAttributesState.WaitingForReview,
                "WAITING_FOR_SCREENSHOT" => InAppPurchaseAttributesState.WaitingForScreenshot,
                "WAITING_FOR_UPLOAD" => InAppPurchaseAttributesState.WaitingForUpload,
                _ => null,
            };
        }
    }
}