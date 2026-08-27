
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionAttributesState
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
    public static class SubscriptionVersionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionAttributesState value)
        {
            return value switch
            {
                SubscriptionVersionAttributesState.Accepted => "ACCEPTED",
                SubscriptionVersionAttributesState.Approved => "APPROVED",
                SubscriptionVersionAttributesState.DeveloperRejected => "DEVELOPER_REJECTED",
                SubscriptionVersionAttributesState.InReview => "IN_REVIEW",
                SubscriptionVersionAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                SubscriptionVersionAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                SubscriptionVersionAttributesState.Rejected => "REJECTED",
                SubscriptionVersionAttributesState.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                SubscriptionVersionAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => SubscriptionVersionAttributesState.Accepted,
                "APPROVED" => SubscriptionVersionAttributesState.Approved,
                "DEVELOPER_REJECTED" => SubscriptionVersionAttributesState.DeveloperRejected,
                "IN_REVIEW" => SubscriptionVersionAttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => SubscriptionVersionAttributesState.PrepareForSubmission,
                "READY_FOR_REVIEW" => SubscriptionVersionAttributesState.ReadyForReview,
                "REJECTED" => SubscriptionVersionAttributesState.Rejected,
                "REPLACED_WITH_NEW_VERSION" => SubscriptionVersionAttributesState.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => SubscriptionVersionAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}