
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppVersionState
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
    public static class AppVersionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppVersionState value)
        {
            return value switch
            {
                AppVersionState.Accepted => "ACCEPTED",
                AppVersionState.DeveloperRejected => "DEVELOPER_REJECTED",
                AppVersionState.InvalidBinary => "INVALID_BINARY",
                AppVersionState.InReview => "IN_REVIEW",
                AppVersionState.MetadataRejected => "METADATA_REJECTED",
                AppVersionState.PendingAppleRelease => "PENDING_APPLE_RELEASE",
                AppVersionState.PendingDeveloperRelease => "PENDING_DEVELOPER_RELEASE",
                AppVersionState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppVersionState.ProcessingForDistribution => "PROCESSING_FOR_DISTRIBUTION",
                AppVersionState.ReadyForDistribution => "READY_FOR_DISTRIBUTION",
                AppVersionState.ReadyForReview => "READY_FOR_REVIEW",
                AppVersionState.Rejected => "REJECTED",
                AppVersionState.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppVersionState.WaitingForExportCompliance => "WAITING_FOR_EXPORT_COMPLIANCE",
                AppVersionState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppVersionState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppVersionState.Accepted,
                "DEVELOPER_REJECTED" => AppVersionState.DeveloperRejected,
                "INVALID_BINARY" => AppVersionState.InvalidBinary,
                "IN_REVIEW" => AppVersionState.InReview,
                "METADATA_REJECTED" => AppVersionState.MetadataRejected,
                "PENDING_APPLE_RELEASE" => AppVersionState.PendingAppleRelease,
                "PENDING_DEVELOPER_RELEASE" => AppVersionState.PendingDeveloperRelease,
                "PREPARE_FOR_SUBMISSION" => AppVersionState.PrepareForSubmission,
                "PROCESSING_FOR_DISTRIBUTION" => AppVersionState.ProcessingForDistribution,
                "READY_FOR_DISTRIBUTION" => AppVersionState.ReadyForDistribution,
                "READY_FOR_REVIEW" => AppVersionState.ReadyForReview,
                "REJECTED" => AppVersionState.Rejected,
                "REPLACED_WITH_NEW_VERSION" => AppVersionState.ReplacedWithNewVersion,
                "WAITING_FOR_EXPORT_COMPLIANCE" => AppVersionState.WaitingForExportCompliance,
                "WAITING_FOR_REVIEW" => AppVersionState.WaitingForReview,
                _ => null,
            };
        }
    }
}