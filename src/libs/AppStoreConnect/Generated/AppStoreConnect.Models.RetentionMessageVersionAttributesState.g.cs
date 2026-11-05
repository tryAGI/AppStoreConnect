
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionAttributesState
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
        DeveloperRejected,
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
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionAttributesState value)
        {
            return value switch
            {
                RetentionMessageVersionAttributesState.Accepted => "ACCEPTED",
                RetentionMessageVersionAttributesState.Approved => "APPROVED",
                RetentionMessageVersionAttributesState.DeveloperRejected => "DEVELOPER_REJECTED",
                RetentionMessageVersionAttributesState.InReview => "IN_REVIEW",
                RetentionMessageVersionAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                RetentionMessageVersionAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                RetentionMessageVersionAttributesState.Rejected => "REJECTED",
                RetentionMessageVersionAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => RetentionMessageVersionAttributesState.Accepted,
                "APPROVED" => RetentionMessageVersionAttributesState.Approved,
                "DEVELOPER_REJECTED" => RetentionMessageVersionAttributesState.DeveloperRejected,
                "IN_REVIEW" => RetentionMessageVersionAttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => RetentionMessageVersionAttributesState.PrepareForSubmission,
                "READY_FOR_REVIEW" => RetentionMessageVersionAttributesState.ReadyForReview,
                "REJECTED" => RetentionMessageVersionAttributesState.Rejected,
                "WAITING_FOR_REVIEW" => RetentionMessageVersionAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}