
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.AssetProcessing => "ASSET_PROCESSING",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.Failed => "FAILED",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentApproved => "PARENT_APPROVED",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentInReview => "PARENT_IN_REVIEW",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission => "PARENT_PREPARE_FOR_SUBMISSION",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview => "PARENT_READY_FOR_REVIEW",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview => "PARENT_WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ASSET_PROCESSING" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.AssetProcessing,
                "FAILED" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.Failed,
                "PARENT_APPROVED" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentApproved,
                "PARENT_IN_REVIEW" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentInReview,
                "PARENT_PREPARE_FOR_SUBMISSION" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission,
                "PARENT_READY_FOR_REVIEW" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview,
                "PARENT_WAITING_FOR_REVIEW" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview,
                _ => null,
            };
        }
    }
}