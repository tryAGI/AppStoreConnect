
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionState
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        DeveloperRejected,
        /// <summary>
        ///
        /// </summary>
        DeveloperRemovedFromSale,
        /// <summary>
        ///
        /// </summary>
        InvalidBinary,
        /// <summary>
        ///
        /// </summary>
        InReview,
        /// <summary>
        ///
        /// </summary>
        MetadataRejected,
        /// <summary>
        ///
        /// </summary>
        NotApplicable,
        /// <summary>
        ///
        /// </summary>
        PendingAppleRelease,
        /// <summary>
        ///
        /// </summary>
        PendingContract,
        /// <summary>
        ///
        /// </summary>
        PendingDeveloperRelease,
        /// <summary>
        ///
        /// </summary>
        PreorderReadyForSale,
        /// <summary>
        ///
        /// </summary>
        PrepareForSubmission,
        /// <summary>
        ///
        /// </summary>
        ProcessingForAppStore,
        /// <summary>
        ///
        /// </summary>
        ReadyForReview,
        /// <summary>
        ///
        /// </summary>
        ReadyForSale,
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
        ReplacedWithNewVersion,
        /// <summary>
        ///
        /// </summary>
        WaitingForExportCompliance,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionState value)
        {
            return value switch
            {
                AppStoreVersionState.Accepted => "ACCEPTED",
                AppStoreVersionState.DeveloperRejected => "DEVELOPER_REJECTED",
                AppStoreVersionState.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                AppStoreVersionState.InvalidBinary => "INVALID_BINARY",
                AppStoreVersionState.InReview => "IN_REVIEW",
                AppStoreVersionState.MetadataRejected => "METADATA_REJECTED",
                AppStoreVersionState.NotApplicable => "NOT_APPLICABLE",
                AppStoreVersionState.PendingAppleRelease => "PENDING_APPLE_RELEASE",
                AppStoreVersionState.PendingContract => "PENDING_CONTRACT",
                AppStoreVersionState.PendingDeveloperRelease => "PENDING_DEVELOPER_RELEASE",
                AppStoreVersionState.PreorderReadyForSale => "PREORDER_READY_FOR_SALE",
                AppStoreVersionState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppStoreVersionState.ProcessingForAppStore => "PROCESSING_FOR_APP_STORE",
                AppStoreVersionState.ReadyForReview => "READY_FOR_REVIEW",
                AppStoreVersionState.ReadyForSale => "READY_FOR_SALE",
                AppStoreVersionState.Rejected => "REJECTED",
                AppStoreVersionState.RemovedFromSale => "REMOVED_FROM_SALE",
                AppStoreVersionState.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppStoreVersionState.WaitingForExportCompliance => "WAITING_FOR_EXPORT_COMPLIANCE",
                AppStoreVersionState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppStoreVersionState.Accepted,
                "DEVELOPER_REJECTED" => AppStoreVersionState.DeveloperRejected,
                "DEVELOPER_REMOVED_FROM_SALE" => AppStoreVersionState.DeveloperRemovedFromSale,
                "INVALID_BINARY" => AppStoreVersionState.InvalidBinary,
                "IN_REVIEW" => AppStoreVersionState.InReview,
                "METADATA_REJECTED" => AppStoreVersionState.MetadataRejected,
                "NOT_APPLICABLE" => AppStoreVersionState.NotApplicable,
                "PENDING_APPLE_RELEASE" => AppStoreVersionState.PendingAppleRelease,
                "PENDING_CONTRACT" => AppStoreVersionState.PendingContract,
                "PENDING_DEVELOPER_RELEASE" => AppStoreVersionState.PendingDeveloperRelease,
                "PREORDER_READY_FOR_SALE" => AppStoreVersionState.PreorderReadyForSale,
                "PREPARE_FOR_SUBMISSION" => AppStoreVersionState.PrepareForSubmission,
                "PROCESSING_FOR_APP_STORE" => AppStoreVersionState.ProcessingForAppStore,
                "READY_FOR_REVIEW" => AppStoreVersionState.ReadyForReview,
                "READY_FOR_SALE" => AppStoreVersionState.ReadyForSale,
                "REJECTED" => AppStoreVersionState.Rejected,
                "REMOVED_FROM_SALE" => AppStoreVersionState.RemovedFromSale,
                "REPLACED_WITH_NEW_VERSION" => AppStoreVersionState.ReplacedWithNewVersion,
                "WAITING_FOR_EXPORT_COMPLIANCE" => AppStoreVersionState.WaitingForExportCompliance,
                "WAITING_FOR_REVIEW" => AppStoreVersionState.WaitingForReview,
                _ => null,
            };
        }
    }
}