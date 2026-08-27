
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem
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
    public static class AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.Accepted => "ACCEPTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.DeveloperRejected => "DEVELOPER_REJECTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.InvalidBinary => "INVALID_BINARY",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.InReview => "IN_REVIEW",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.MetadataRejected => "METADATA_REJECTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.NotApplicable => "NOT_APPLICABLE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PendingAppleRelease => "PENDING_APPLE_RELEASE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PendingContract => "PENDING_CONTRACT",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PendingDeveloperRelease => "PENDING_DEVELOPER_RELEASE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PreorderReadyForSale => "PREORDER_READY_FOR_SALE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ProcessingForAppStore => "PROCESSING_FOR_APP_STORE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ReadyForSale => "READY_FOR_SALE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.Rejected => "REJECTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.RemovedFromSale => "REMOVED_FROM_SALE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.WaitingForExportCompliance => "WAITING_FOR_EXPORT_COMPLIANCE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.Accepted,
                "DEVELOPER_REJECTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.DeveloperRejected,
                "DEVELOPER_REMOVED_FROM_SALE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.DeveloperRemovedFromSale,
                "INVALID_BINARY" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.InvalidBinary,
                "IN_REVIEW" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.InReview,
                "METADATA_REJECTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.MetadataRejected,
                "NOT_APPLICABLE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.NotApplicable,
                "PENDING_APPLE_RELEASE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PendingAppleRelease,
                "PENDING_CONTRACT" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PendingContract,
                "PENDING_DEVELOPER_RELEASE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PendingDeveloperRelease,
                "PREORDER_READY_FOR_SALE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PreorderReadyForSale,
                "PREPARE_FOR_SUBMISSION" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.PrepareForSubmission,
                "PROCESSING_FOR_APP_STORE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ProcessingForAppStore,
                "READY_FOR_REVIEW" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ReadyForReview,
                "READY_FOR_SALE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ReadyForSale,
                "REJECTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.Rejected,
                "REMOVED_FROM_SALE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.RemovedFromSale,
                "REPLACED_WITH_NEW_VERSION" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_EXPORT_COMPLIANCE" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.WaitingForExportCompliance,
                "WAITING_FOR_REVIEW" => AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}