
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupLocalizationAttributesState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
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
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationAttributesState value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationAttributesState.Approved => "APPROVED",
                SubscriptionGroupLocalizationAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                SubscriptionGroupLocalizationAttributesState.Rejected => "REJECTED",
                SubscriptionGroupLocalizationAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => SubscriptionGroupLocalizationAttributesState.Approved,
                "PREPARE_FOR_SUBMISSION" => SubscriptionGroupLocalizationAttributesState.PrepareForSubmission,
                "REJECTED" => SubscriptionGroupLocalizationAttributesState.Rejected,
                "WAITING_FOR_REVIEW" => SubscriptionGroupLocalizationAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}