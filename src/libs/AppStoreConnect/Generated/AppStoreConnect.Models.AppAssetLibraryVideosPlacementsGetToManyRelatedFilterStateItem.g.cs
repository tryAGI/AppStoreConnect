
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.AssetProcessing => "ASSET_PROCESSING",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.Failed => "FAILED",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentApproved => "PARENT_APPROVED",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentInReview => "PARENT_IN_REVIEW",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission => "PARENT_PREPARE_FOR_SUBMISSION",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview => "PARENT_READY_FOR_REVIEW",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview => "PARENT_WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ASSET_PROCESSING" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.AssetProcessing,
                "FAILED" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.Failed,
                "PARENT_APPROVED" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentApproved,
                "PARENT_IN_REVIEW" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentInReview,
                "PARENT_PREPARE_FOR_SUBMISSION" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission,
                "PARENT_READY_FOR_REVIEW" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview,
                "PARENT_WAITING_FOR_REVIEW" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview,
                _ => null,
            };
        }
    }
}