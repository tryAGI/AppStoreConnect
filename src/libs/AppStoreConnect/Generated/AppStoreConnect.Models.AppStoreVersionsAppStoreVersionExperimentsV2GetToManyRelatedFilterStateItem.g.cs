
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem
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
    public static class AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Approved => "APPROVED",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Completed => "COMPLETED",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Stopped => "STOPPED",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Approved,
                "COMPLETED" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Completed,
                "IN_REVIEW" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Rejected,
                "STOPPED" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.Stopped,
                "WAITING_FOR_REVIEW" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}