
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImageAttributesState
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        AwaitingUpload,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        PrepareForSubmission,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        UploadComplete,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImageAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImageAttributesState value)
        {
            return value switch
            {
                SubscriptionImageAttributesState.Approved => "APPROVED",
                SubscriptionImageAttributesState.AwaitingUpload => "AWAITING_UPLOAD",
                SubscriptionImageAttributesState.Failed => "FAILED",
                SubscriptionImageAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                SubscriptionImageAttributesState.Rejected => "REJECTED",
                SubscriptionImageAttributesState.UploadComplete => "UPLOAD_COMPLETE",
                SubscriptionImageAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImageAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => SubscriptionImageAttributesState.Approved,
                "AWAITING_UPLOAD" => SubscriptionImageAttributesState.AwaitingUpload,
                "FAILED" => SubscriptionImageAttributesState.Failed,
                "PREPARE_FOR_SUBMISSION" => SubscriptionImageAttributesState.PrepareForSubmission,
                "REJECTED" => SubscriptionImageAttributesState.Rejected,
                "UPLOAD_COMPLETE" => SubscriptionImageAttributesState.UploadComplete,
                "WAITING_FOR_REVIEW" => SubscriptionImageAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}