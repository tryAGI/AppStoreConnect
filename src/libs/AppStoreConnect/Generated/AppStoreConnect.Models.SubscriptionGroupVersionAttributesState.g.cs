
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionAttributesState
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
    public static class SubscriptionGroupVersionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionAttributesState value)
        {
            return value switch
            {
                SubscriptionGroupVersionAttributesState.Accepted => "ACCEPTED",
                SubscriptionGroupVersionAttributesState.Approved => "APPROVED",
                SubscriptionGroupVersionAttributesState.DeveloperRejected => "DEVELOPER_REJECTED",
                SubscriptionGroupVersionAttributesState.InReview => "IN_REVIEW",
                SubscriptionGroupVersionAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                SubscriptionGroupVersionAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                SubscriptionGroupVersionAttributesState.Rejected => "REJECTED",
                SubscriptionGroupVersionAttributesState.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                SubscriptionGroupVersionAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => SubscriptionGroupVersionAttributesState.Accepted,
                "APPROVED" => SubscriptionGroupVersionAttributesState.Approved,
                "DEVELOPER_REJECTED" => SubscriptionGroupVersionAttributesState.DeveloperRejected,
                "IN_REVIEW" => SubscriptionGroupVersionAttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => SubscriptionGroupVersionAttributesState.PrepareForSubmission,
                "READY_FOR_REVIEW" => SubscriptionGroupVersionAttributesState.ReadyForReview,
                "REJECTED" => SubscriptionGroupVersionAttributesState.Rejected,
                "REPLACED_WITH_NEW_VERSION" => SubscriptionGroupVersionAttributesState.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => SubscriptionGroupVersionAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}