
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentV2AttributesState
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        PrepareForSubmission,
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
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentV2AttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentV2AttributesState value)
        {
            return value switch
            {
                AppStoreVersionExperimentV2AttributesState.Accepted => "ACCEPTED",
                AppStoreVersionExperimentV2AttributesState.Approved => "APPROVED",
                AppStoreVersionExperimentV2AttributesState.Completed => "COMPLETED",
                AppStoreVersionExperimentV2AttributesState.InReview => "IN_REVIEW",
                AppStoreVersionExperimentV2AttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppStoreVersionExperimentV2AttributesState.ReadyForReview => "READY_FOR_REVIEW",
                AppStoreVersionExperimentV2AttributesState.Rejected => "REJECTED",
                AppStoreVersionExperimentV2AttributesState.Stopped => "STOPPED",
                AppStoreVersionExperimentV2AttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentV2AttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppStoreVersionExperimentV2AttributesState.Accepted,
                "APPROVED" => AppStoreVersionExperimentV2AttributesState.Approved,
                "COMPLETED" => AppStoreVersionExperimentV2AttributesState.Completed,
                "IN_REVIEW" => AppStoreVersionExperimentV2AttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => AppStoreVersionExperimentV2AttributesState.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppStoreVersionExperimentV2AttributesState.ReadyForReview,
                "REJECTED" => AppStoreVersionExperimentV2AttributesState.Rejected,
                "STOPPED" => AppStoreVersionExperimentV2AttributesState.Stopped,
                "WAITING_FOR_REVIEW" => AppStoreVersionExperimentV2AttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}