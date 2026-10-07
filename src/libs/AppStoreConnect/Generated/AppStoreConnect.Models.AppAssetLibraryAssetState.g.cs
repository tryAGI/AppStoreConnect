
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryAssetState
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
        AwaitingUpload,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Failed,
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
        UploadComplete,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryAssetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryAssetState value)
        {
            return value switch
            {
                AppAssetLibraryAssetState.Accepted => "ACCEPTED",
                AppAssetLibraryAssetState.Approved => "APPROVED",
                AppAssetLibraryAssetState.Archived => "ARCHIVED",
                AppAssetLibraryAssetState.AwaitingUpload => "AWAITING_UPLOAD",
                AppAssetLibraryAssetState.Complete => "COMPLETE",
                AppAssetLibraryAssetState.Failed => "FAILED",
                AppAssetLibraryAssetState.InReview => "IN_REVIEW",
                AppAssetLibraryAssetState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppAssetLibraryAssetState.ReadyForReview => "READY_FOR_REVIEW",
                AppAssetLibraryAssetState.Rejected => "REJECTED",
                AppAssetLibraryAssetState.UploadComplete => "UPLOAD_COMPLETE",
                AppAssetLibraryAssetState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryAssetState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppAssetLibraryAssetState.Accepted,
                "APPROVED" => AppAssetLibraryAssetState.Approved,
                "ARCHIVED" => AppAssetLibraryAssetState.Archived,
                "AWAITING_UPLOAD" => AppAssetLibraryAssetState.AwaitingUpload,
                "COMPLETE" => AppAssetLibraryAssetState.Complete,
                "FAILED" => AppAssetLibraryAssetState.Failed,
                "IN_REVIEW" => AppAssetLibraryAssetState.InReview,
                "PREPARE_FOR_SUBMISSION" => AppAssetLibraryAssetState.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppAssetLibraryAssetState.ReadyForReview,
                "REJECTED" => AppAssetLibraryAssetState.Rejected,
                "UPLOAD_COMPLETE" => AppAssetLibraryAssetState.UploadComplete,
                "WAITING_FOR_REVIEW" => AppAssetLibraryAssetState.WaitingForReview,
                _ => null,
            };
        }
    }
}