
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem
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
        Completed,
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
        Stopped,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Approved => "APPROVED",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Completed => "COMPLETED",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Stopped => "STOPPED",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Approved,
                "COMPLETED" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Completed,
                "IN_REVIEW" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Rejected,
                "STOPPED" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Stopped,
                "WAITING_FOR_REVIEW" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}