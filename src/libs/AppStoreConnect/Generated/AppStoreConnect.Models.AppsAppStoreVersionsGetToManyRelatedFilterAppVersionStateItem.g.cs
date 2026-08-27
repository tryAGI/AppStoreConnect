
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem
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
    public static class AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.Accepted => "ACCEPTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.DeveloperRejected => "DEVELOPER_REJECTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.InvalidBinary => "INVALID_BINARY",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.InReview => "IN_REVIEW",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.MetadataRejected => "METADATA_REJECTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.PendingAppleRelease => "PENDING_APPLE_RELEASE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.PendingDeveloperRelease => "PENDING_DEVELOPER_RELEASE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ProcessingForDistribution => "PROCESSING_FOR_DISTRIBUTION",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ReadyForDistribution => "READY_FOR_DISTRIBUTION",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.Rejected => "REJECTED",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.WaitingForExportCompliance => "WAITING_FOR_EXPORT_COMPLIANCE",
                AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.Accepted,
                "DEVELOPER_REJECTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.DeveloperRejected,
                "INVALID_BINARY" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.InvalidBinary,
                "IN_REVIEW" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.InReview,
                "METADATA_REJECTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.MetadataRejected,
                "PENDING_APPLE_RELEASE" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.PendingAppleRelease,
                "PENDING_DEVELOPER_RELEASE" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.PendingDeveloperRelease,
                "PREPARE_FOR_SUBMISSION" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.PrepareForSubmission,
                "PROCESSING_FOR_DISTRIBUTION" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ProcessingForDistribution,
                "READY_FOR_DISTRIBUTION" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ReadyForDistribution,
                "READY_FOR_REVIEW" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ReadyForReview,
                "REJECTED" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.Rejected,
                "REPLACED_WITH_NEW_VERSION" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_EXPORT_COMPLIANCE" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.WaitingForExportCompliance,
                "WAITING_FOR_REVIEW" => AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}