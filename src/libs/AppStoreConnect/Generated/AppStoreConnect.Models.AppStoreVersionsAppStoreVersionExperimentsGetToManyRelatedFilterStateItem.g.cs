
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem
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
    public static class AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Completed => "COMPLETED",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Stopped => "STOPPED",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Approved,
                "COMPLETED" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Completed,
                "IN_REVIEW" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Rejected,
                "STOPPED" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.Stopped,
                "WAITING_FOR_REVIEW" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}