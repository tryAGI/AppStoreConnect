
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentAttributesState
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
    public static class AppStoreVersionExperimentAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentAttributesState value)
        {
            return value switch
            {
                AppStoreVersionExperimentAttributesState.Accepted => "ACCEPTED",
                AppStoreVersionExperimentAttributesState.Approved => "APPROVED",
                AppStoreVersionExperimentAttributesState.Completed => "COMPLETED",
                AppStoreVersionExperimentAttributesState.InReview => "IN_REVIEW",
                AppStoreVersionExperimentAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppStoreVersionExperimentAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                AppStoreVersionExperimentAttributesState.Rejected => "REJECTED",
                AppStoreVersionExperimentAttributesState.Stopped => "STOPPED",
                AppStoreVersionExperimentAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppStoreVersionExperimentAttributesState.Accepted,
                "APPROVED" => AppStoreVersionExperimentAttributesState.Approved,
                "COMPLETED" => AppStoreVersionExperimentAttributesState.Completed,
                "IN_REVIEW" => AppStoreVersionExperimentAttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => AppStoreVersionExperimentAttributesState.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppStoreVersionExperimentAttributesState.ReadyForReview,
                "REJECTED" => AppStoreVersionExperimentAttributesState.Rejected,
                "STOPPED" => AppStoreVersionExperimentAttributesState.Stopped,
                "WAITING_FOR_REVIEW" => AppStoreVersionExperimentAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}