
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemAttributesState
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
        ReadyForReview,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemAttributesState value)
        {
            return value switch
            {
                ReviewSubmissionItemAttributesState.Accepted => "ACCEPTED",
                ReviewSubmissionItemAttributesState.Approved => "APPROVED",
                ReviewSubmissionItemAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                ReviewSubmissionItemAttributesState.Rejected => "REJECTED",
                ReviewSubmissionItemAttributesState.Removed => "REMOVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => ReviewSubmissionItemAttributesState.Accepted,
                "APPROVED" => ReviewSubmissionItemAttributesState.Approved,
                "READY_FOR_REVIEW" => ReviewSubmissionItemAttributesState.ReadyForReview,
                "REJECTED" => ReviewSubmissionItemAttributesState.Rejected,
                "REMOVED" => ReviewSubmissionItemAttributesState.Removed,
                _ => null,
            };
        }
    }
}