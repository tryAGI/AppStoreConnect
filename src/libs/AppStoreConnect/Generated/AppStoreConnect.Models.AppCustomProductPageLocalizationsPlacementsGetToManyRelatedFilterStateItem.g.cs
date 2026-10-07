
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem
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
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.AssetProcessing => "ASSET_PROCESSING",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.Failed => "FAILED",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentApproved => "PARENT_APPROVED",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentInReview => "PARENT_IN_REVIEW",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission => "PARENT_PREPARE_FOR_SUBMISSION",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview => "PARENT_READY_FOR_REVIEW",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview => "PARENT_WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ASSET_PROCESSING" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.AssetProcessing,
                "FAILED" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.Failed,
                "PARENT_APPROVED" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentApproved,
                "PARENT_IN_REVIEW" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentInReview,
                "PARENT_PREPARE_FOR_SUBMISSION" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission,
                "PARENT_READY_FOR_REVIEW" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview,
                "PARENT_WAITING_FOR_REVIEW" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview,
                _ => null,
            };
        }
    }
}