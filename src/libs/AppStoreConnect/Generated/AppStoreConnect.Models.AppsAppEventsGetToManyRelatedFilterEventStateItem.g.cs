
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppEventsGetToManyRelatedFilterEventStateItem
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
    public static class AppsAppEventsGetToManyRelatedFilterEventStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEventsGetToManyRelatedFilterEventStateItem value)
        {
            return value switch
            {
                AppsAppEventsGetToManyRelatedFilterEventStateItem.Accepted => "ACCEPTED",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.Approved => "APPROVED",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.Archived => "ARCHIVED",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.Draft => "DRAFT",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.InReview => "IN_REVIEW",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.Past => "PAST",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.Published => "PUBLISHED",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.Rejected => "REJECTED",
                AppsAppEventsGetToManyRelatedFilterEventStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEventsGetToManyRelatedFilterEventStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppsAppEventsGetToManyRelatedFilterEventStateItem.Accepted,
                "APPROVED" => AppsAppEventsGetToManyRelatedFilterEventStateItem.Approved,
                "ARCHIVED" => AppsAppEventsGetToManyRelatedFilterEventStateItem.Archived,
                "DRAFT" => AppsAppEventsGetToManyRelatedFilterEventStateItem.Draft,
                "IN_REVIEW" => AppsAppEventsGetToManyRelatedFilterEventStateItem.InReview,
                "PAST" => AppsAppEventsGetToManyRelatedFilterEventStateItem.Past,
                "PUBLISHED" => AppsAppEventsGetToManyRelatedFilterEventStateItem.Published,
                "READY_FOR_REVIEW" => AppsAppEventsGetToManyRelatedFilterEventStateItem.ReadyForReview,
                "REJECTED" => AppsAppEventsGetToManyRelatedFilterEventStateItem.Rejected,
                "WAITING_FOR_REVIEW" => AppsAppEventsGetToManyRelatedFilterEventStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}