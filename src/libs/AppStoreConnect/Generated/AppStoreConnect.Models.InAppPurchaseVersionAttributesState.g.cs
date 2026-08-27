
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionAttributesState
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
        ReplacedWithNewVersion,
        /// <summary>
        /// 
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionAttributesState value)
        {
            return value switch
            {
                InAppPurchaseVersionAttributesState.Accepted => "ACCEPTED",
                InAppPurchaseVersionAttributesState.Approved => "APPROVED",
                InAppPurchaseVersionAttributesState.DeveloperRejected => "DEVELOPER_REJECTED",
                InAppPurchaseVersionAttributesState.InReview => "IN_REVIEW",
                InAppPurchaseVersionAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                InAppPurchaseVersionAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                InAppPurchaseVersionAttributesState.Rejected => "REJECTED",
                InAppPurchaseVersionAttributesState.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                InAppPurchaseVersionAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => InAppPurchaseVersionAttributesState.Accepted,
                "APPROVED" => InAppPurchaseVersionAttributesState.Approved,
                "DEVELOPER_REJECTED" => InAppPurchaseVersionAttributesState.DeveloperRejected,
                "IN_REVIEW" => InAppPurchaseVersionAttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => InAppPurchaseVersionAttributesState.PrepareForSubmission,
                "READY_FOR_REVIEW" => InAppPurchaseVersionAttributesState.ReadyForReview,
                "REJECTED" => InAppPurchaseVersionAttributesState.Rejected,
                "REPLACED_WITH_NEW_VERSION" => InAppPurchaseVersionAttributesState.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => InAppPurchaseVersionAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}