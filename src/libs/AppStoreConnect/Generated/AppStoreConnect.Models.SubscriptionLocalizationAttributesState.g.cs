
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationAttributesState
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
    public static class SubscriptionLocalizationAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationAttributesState value)
        {
            return value switch
            {
                SubscriptionLocalizationAttributesState.Approved => "APPROVED",
                SubscriptionLocalizationAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                SubscriptionLocalizationAttributesState.Rejected => "REJECTED",
                SubscriptionLocalizationAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => SubscriptionLocalizationAttributesState.Approved,
                "PREPARE_FOR_SUBMISSION" => SubscriptionLocalizationAttributesState.PrepareForSubmission,
                "REJECTED" => SubscriptionLocalizationAttributesState.Rejected,
                "WAITING_FOR_REVIEW" => SubscriptionLocalizationAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}