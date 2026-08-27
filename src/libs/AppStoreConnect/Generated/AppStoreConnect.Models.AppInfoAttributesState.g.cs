
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoAttributesState
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
        InReview,
        /// <summary>
        /// 
        /// </summary>
        PendingRelease,
        /// <summary>
        /// 
        /// </summary>
        PrepareForSubmission,
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
        ReplacedWithNewInfo,
        /// <summary>
        /// 
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoAttributesState value)
        {
            return value switch
            {
                AppInfoAttributesState.Accepted => "ACCEPTED",
                AppInfoAttributesState.DeveloperRejected => "DEVELOPER_REJECTED",
                AppInfoAttributesState.InReview => "IN_REVIEW",
                AppInfoAttributesState.PendingRelease => "PENDING_RELEASE",
                AppInfoAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppInfoAttributesState.ReadyForDistribution => "READY_FOR_DISTRIBUTION",
                AppInfoAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                AppInfoAttributesState.Rejected => "REJECTED",
                AppInfoAttributesState.ReplacedWithNewInfo => "REPLACED_WITH_NEW_INFO",
                AppInfoAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppInfoAttributesState.Accepted,
                "DEVELOPER_REJECTED" => AppInfoAttributesState.DeveloperRejected,
                "IN_REVIEW" => AppInfoAttributesState.InReview,
                "PENDING_RELEASE" => AppInfoAttributesState.PendingRelease,
                "PREPARE_FOR_SUBMISSION" => AppInfoAttributesState.PrepareForSubmission,
                "READY_FOR_DISTRIBUTION" => AppInfoAttributesState.ReadyForDistribution,
                "READY_FOR_REVIEW" => AppInfoAttributesState.ReadyForReview,
                "REJECTED" => AppInfoAttributesState.Rejected,
                "REPLACED_WITH_NEW_INFO" => AppInfoAttributesState.ReplacedWithNewInfo,
                "WAITING_FOR_REVIEW" => AppInfoAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}