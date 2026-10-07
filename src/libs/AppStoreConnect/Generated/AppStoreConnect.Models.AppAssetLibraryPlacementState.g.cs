
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementState
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
    public static class AppAssetLibraryPlacementStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementState value)
        {
            return value switch
            {
                AppAssetLibraryPlacementState.AssetProcessing => "ASSET_PROCESSING",
                AppAssetLibraryPlacementState.Failed => "FAILED",
                AppAssetLibraryPlacementState.ParentApproved => "PARENT_APPROVED",
                AppAssetLibraryPlacementState.ParentInReview => "PARENT_IN_REVIEW",
                AppAssetLibraryPlacementState.ParentPrepareForSubmission => "PARENT_PREPARE_FOR_SUBMISSION",
                AppAssetLibraryPlacementState.ParentReadyForReview => "PARENT_READY_FOR_REVIEW",
                AppAssetLibraryPlacementState.ParentWaitingForReview => "PARENT_WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementState? ToEnum(string value)
        {
            return value switch
            {
                "ASSET_PROCESSING" => AppAssetLibraryPlacementState.AssetProcessing,
                "FAILED" => AppAssetLibraryPlacementState.Failed,
                "PARENT_APPROVED" => AppAssetLibraryPlacementState.ParentApproved,
                "PARENT_IN_REVIEW" => AppAssetLibraryPlacementState.ParentInReview,
                "PARENT_PREPARE_FOR_SUBMISSION" => AppAssetLibraryPlacementState.ParentPrepareForSubmission,
                "PARENT_READY_FOR_REVIEW" => AppAssetLibraryPlacementState.ParentReadyForReview,
                "PARENT_WAITING_FOR_REVIEW" => AppAssetLibraryPlacementState.ParentWaitingForReview,
                _ => null,
            };
        }
    }
}