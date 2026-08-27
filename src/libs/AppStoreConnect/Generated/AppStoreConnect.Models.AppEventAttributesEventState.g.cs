
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventAttributesEventState
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
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        Past,
        /// <summary>
        /// 
        /// </summary>
        Published,
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
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventAttributesEventStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventAttributesEventState value)
        {
            return value switch
            {
                AppEventAttributesEventState.Accepted => "ACCEPTED",
                AppEventAttributesEventState.Approved => "APPROVED",
                AppEventAttributesEventState.Archived => "ARCHIVED",
                AppEventAttributesEventState.Draft => "DRAFT",
                AppEventAttributesEventState.InReview => "IN_REVIEW",
                AppEventAttributesEventState.Past => "PAST",
                AppEventAttributesEventState.Published => "PUBLISHED",
                AppEventAttributesEventState.ReadyForReview => "READY_FOR_REVIEW",
                AppEventAttributesEventState.Rejected => "REJECTED",
                AppEventAttributesEventState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventAttributesEventState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppEventAttributesEventState.Accepted,
                "APPROVED" => AppEventAttributesEventState.Approved,
                "ARCHIVED" => AppEventAttributesEventState.Archived,
                "DRAFT" => AppEventAttributesEventState.Draft,
                "IN_REVIEW" => AppEventAttributesEventState.InReview,
                "PAST" => AppEventAttributesEventState.Past,
                "PUBLISHED" => AppEventAttributesEventState.Published,
                "READY_FOR_REVIEW" => AppEventAttributesEventState.ReadyForReview,
                "REJECTED" => AppEventAttributesEventState.Rejected,
                "WAITING_FOR_REVIEW" => AppEventAttributesEventState.WaitingForReview,
                _ => null,
            };
        }
    }
}