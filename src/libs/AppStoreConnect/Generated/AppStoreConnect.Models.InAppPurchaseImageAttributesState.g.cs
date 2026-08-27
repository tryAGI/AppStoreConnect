
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseImageAttributesState
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
    public static class InAppPurchaseImageAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImageAttributesState value)
        {
            return value switch
            {
                InAppPurchaseImageAttributesState.Approved => "APPROVED",
                InAppPurchaseImageAttributesState.AwaitingUpload => "AWAITING_UPLOAD",
                InAppPurchaseImageAttributesState.Failed => "FAILED",
                InAppPurchaseImageAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                InAppPurchaseImageAttributesState.Rejected => "REJECTED",
                InAppPurchaseImageAttributesState.UploadComplete => "UPLOAD_COMPLETE",
                InAppPurchaseImageAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImageAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => InAppPurchaseImageAttributesState.Approved,
                "AWAITING_UPLOAD" => InAppPurchaseImageAttributesState.AwaitingUpload,
                "FAILED" => InAppPurchaseImageAttributesState.Failed,
                "PREPARE_FOR_SUBMISSION" => InAppPurchaseImageAttributesState.PrepareForSubmission,
                "REJECTED" => InAppPurchaseImageAttributesState.Rejected,
                "UPLOAD_COMPLETE" => InAppPurchaseImageAttributesState.UploadComplete,
                "WAITING_FOR_REVIEW" => InAppPurchaseImageAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}