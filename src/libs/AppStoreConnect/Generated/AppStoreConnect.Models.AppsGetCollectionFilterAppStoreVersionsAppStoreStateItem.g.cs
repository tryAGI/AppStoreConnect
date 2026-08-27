
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem
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
    public static class AppsGetCollectionFilterAppStoreVersionsAppStoreStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem value)
        {
            return value switch
            {
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.Accepted => "ACCEPTED",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.DeveloperRejected => "DEVELOPER_REJECTED",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.InvalidBinary => "INVALID_BINARY",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.InReview => "IN_REVIEW",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.MetadataRejected => "METADATA_REJECTED",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.NotApplicable => "NOT_APPLICABLE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PendingAppleRelease => "PENDING_APPLE_RELEASE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PendingContract => "PENDING_CONTRACT",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PendingDeveloperRelease => "PENDING_DEVELOPER_RELEASE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PreorderReadyForSale => "PREORDER_READY_FOR_SALE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ProcessingForAppStore => "PROCESSING_FOR_APP_STORE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ReadyForSale => "READY_FOR_SALE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.Rejected => "REJECTED",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.RemovedFromSale => "REMOVED_FROM_SALE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.WaitingForExportCompliance => "WAITING_FOR_EXPORT_COMPLIANCE",
                AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.Accepted,
                "DEVELOPER_REJECTED" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.DeveloperRejected,
                "DEVELOPER_REMOVED_FROM_SALE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.DeveloperRemovedFromSale,
                "INVALID_BINARY" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.InvalidBinary,
                "IN_REVIEW" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.InReview,
                "METADATA_REJECTED" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.MetadataRejected,
                "NOT_APPLICABLE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.NotApplicable,
                "PENDING_APPLE_RELEASE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PendingAppleRelease,
                "PENDING_CONTRACT" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PendingContract,
                "PENDING_DEVELOPER_RELEASE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PendingDeveloperRelease,
                "PREORDER_READY_FOR_SALE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PreorderReadyForSale,
                "PREPARE_FOR_SUBMISSION" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.PrepareForSubmission,
                "PROCESSING_FOR_APP_STORE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ProcessingForAppStore,
                "READY_FOR_REVIEW" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ReadyForReview,
                "READY_FOR_SALE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ReadyForSale,
                "REJECTED" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.Rejected,
                "REMOVED_FROM_SALE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.RemovedFromSale,
                "REPLACED_WITH_NEW_VERSION" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_EXPORT_COMPLIANCE" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.WaitingForExportCompliance,
                "WAITING_FOR_REVIEW" => AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}