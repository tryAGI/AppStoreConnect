
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem
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
        PendingAppleRelease,
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
        ProcessingForDistribution,
        /// <summary>
        /// 
        /// </summary>
        ReadyForDistribution,
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
        WaitingForExportCompliance,
        /// <summary>
        /// 
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetCollectionFilterAppStoreVersionsAppVersionStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem value)
        {
            return value switch
            {
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.Accepted => "ACCEPTED",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.DeveloperRejected => "DEVELOPER_REJECTED",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.InvalidBinary => "INVALID_BINARY",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.InReview => "IN_REVIEW",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.MetadataRejected => "METADATA_REJECTED",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.PendingAppleRelease => "PENDING_APPLE_RELEASE",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.PendingDeveloperRelease => "PENDING_DEVELOPER_RELEASE",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ProcessingForDistribution => "PROCESSING_FOR_DISTRIBUTION",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ReadyForDistribution => "READY_FOR_DISTRIBUTION",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.Rejected => "REJECTED",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.WaitingForExportCompliance => "WAITING_FOR_EXPORT_COMPLIANCE",
                AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.Accepted,
                "DEVELOPER_REJECTED" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.DeveloperRejected,
                "INVALID_BINARY" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.InvalidBinary,
                "IN_REVIEW" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.InReview,
                "METADATA_REJECTED" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.MetadataRejected,
                "PENDING_APPLE_RELEASE" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.PendingAppleRelease,
                "PENDING_DEVELOPER_RELEASE" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.PendingDeveloperRelease,
                "PREPARE_FOR_SUBMISSION" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.PrepareForSubmission,
                "PROCESSING_FOR_DISTRIBUTION" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ProcessingForDistribution,
                "READY_FOR_DISTRIBUTION" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ReadyForDistribution,
                "READY_FOR_REVIEW" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ReadyForReview,
                "REJECTED" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.Rejected,
                "REPLACED_WITH_NEW_VERSION" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_EXPORT_COMPLIANCE" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.WaitingForExportCompliance,
                "WAITING_FOR_REVIEW" => AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}