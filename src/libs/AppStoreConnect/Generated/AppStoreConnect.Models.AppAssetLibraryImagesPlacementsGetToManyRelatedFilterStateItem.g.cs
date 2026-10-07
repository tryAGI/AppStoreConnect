
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem
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
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.AssetProcessing => "ASSET_PROCESSING",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.Failed => "FAILED",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentApproved => "PARENT_APPROVED",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentInReview => "PARENT_IN_REVIEW",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission => "PARENT_PREPARE_FOR_SUBMISSION",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview => "PARENT_READY_FOR_REVIEW",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview => "PARENT_WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ASSET_PROCESSING" => AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.AssetProcessing,
                "FAILED" => AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.Failed,
                "PARENT_APPROVED" => AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentApproved,
                "PARENT_IN_REVIEW" => AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentInReview,
                "PARENT_PREPARE_FOR_SUBMISSION" => AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentPrepareForSubmission,
                "PARENT_READY_FOR_REVIEW" => AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentReadyForReview,
                "PARENT_WAITING_FOR_REVIEW" => AppAssetLibraryImagesPlacementsGetToManyRelatedFilterStateItem.ParentWaitingForReview,
                _ => null,
            };
        }
    }
}