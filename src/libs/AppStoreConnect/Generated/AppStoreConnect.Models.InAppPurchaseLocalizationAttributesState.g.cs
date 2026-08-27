
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseLocalizationAttributesState
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
    public static class InAppPurchaseLocalizationAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationAttributesState value)
        {
            return value switch
            {
                InAppPurchaseLocalizationAttributesState.Approved => "APPROVED",
                InAppPurchaseLocalizationAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                InAppPurchaseLocalizationAttributesState.Rejected => "REJECTED",
                InAppPurchaseLocalizationAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => InAppPurchaseLocalizationAttributesState.Approved,
                "PREPARE_FOR_SUBMISSION" => InAppPurchaseLocalizationAttributesState.PrepareForSubmission,
                "REJECTED" => InAppPurchaseLocalizationAttributesState.Rejected,
                "WAITING_FOR_REVIEW" => InAppPurchaseLocalizationAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}