
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem
    {
        /// <summary>
        ///
        /// </summary>
        AssetProcessing,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        ParentApproved,
        /// <summary>
        ///
        /// </summary>
        ParentInReview,
        /// <summary>
        ///
        /// </summary>
        ParentPrepareForSubmission,
        /// <summary>
        ///
        /// </summary>
        ParentReadyForReview,
        /// <summary>
        ///
        /// </summary>
        ParentWaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.AssetProcessing => "ASSET_PROCESSING",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.Failed => "FAILED",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentApproved => "PARENT_APPROVED",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentInReview => "PARENT_IN_REVIEW",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission => "PARENT_PREPARE_FOR_SUBMISSION",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview => "PARENT_READY_FOR_REVIEW",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview => "PARENT_WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ASSET_PROCESSING" => AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.AssetProcessing,
                "FAILED" => AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.Failed,
                "PARENT_APPROVED" => AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentApproved,
                "PARENT_IN_REVIEW" => AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentInReview,
                "PARENT_PREPARE_FOR_SUBMISSION" => AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission,
                "PARENT_READY_FOR_REVIEW" => AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview,
                "PARENT_WAITING_FOR_REVIEW" => AppEventLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview,
                _ => null,
            };
        }
    }
}