
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromotedPurchaseAttributesState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
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
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchaseAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchaseAttributesState value)
        {
            return value switch
            {
                PromotedPurchaseAttributesState.Approved => "APPROVED",
                PromotedPurchaseAttributesState.InReview => "IN_REVIEW",
                PromotedPurchaseAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                PromotedPurchaseAttributesState.Rejected => "REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchaseAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => PromotedPurchaseAttributesState.Approved,
                "IN_REVIEW" => PromotedPurchaseAttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => PromotedPurchaseAttributesState.PrepareForSubmission,
                "REJECTED" => PromotedPurchaseAttributesState.Rejected,
                _ => null,
            };
        }
    }
}