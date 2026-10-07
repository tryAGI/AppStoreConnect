
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideoAttributesDiscriminatorState
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
    public static class AppAssetLibraryVideoAttributesDiscriminatorStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideoAttributesDiscriminatorState value)
        {
            return value switch
            {
                AppAssetLibraryVideoAttributesDiscriminatorState.Accepted => "ACCEPTED",
                AppAssetLibraryVideoAttributesDiscriminatorState.Approved => "APPROVED",
                AppAssetLibraryVideoAttributesDiscriminatorState.Archived => "ARCHIVED",
                AppAssetLibraryVideoAttributesDiscriminatorState.AwaitingUpload => "AWAITING_UPLOAD",
                AppAssetLibraryVideoAttributesDiscriminatorState.Complete => "COMPLETE",
                AppAssetLibraryVideoAttributesDiscriminatorState.Failed => "FAILED",
                AppAssetLibraryVideoAttributesDiscriminatorState.InReview => "IN_REVIEW",
                AppAssetLibraryVideoAttributesDiscriminatorState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppAssetLibraryVideoAttributesDiscriminatorState.ReadyForReview => "READY_FOR_REVIEW",
                AppAssetLibraryVideoAttributesDiscriminatorState.Rejected => "REJECTED",
                AppAssetLibraryVideoAttributesDiscriminatorState.UploadComplete => "UPLOAD_COMPLETE",
                AppAssetLibraryVideoAttributesDiscriminatorState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideoAttributesDiscriminatorState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppAssetLibraryVideoAttributesDiscriminatorState.Accepted,
                "APPROVED" => AppAssetLibraryVideoAttributesDiscriminatorState.Approved,
                "ARCHIVED" => AppAssetLibraryVideoAttributesDiscriminatorState.Archived,
                "AWAITING_UPLOAD" => AppAssetLibraryVideoAttributesDiscriminatorState.AwaitingUpload,
                "COMPLETE" => AppAssetLibraryVideoAttributesDiscriminatorState.Complete,
                "FAILED" => AppAssetLibraryVideoAttributesDiscriminatorState.Failed,
                "IN_REVIEW" => AppAssetLibraryVideoAttributesDiscriminatorState.InReview,
                "PREPARE_FOR_SUBMISSION" => AppAssetLibraryVideoAttributesDiscriminatorState.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppAssetLibraryVideoAttributesDiscriminatorState.ReadyForReview,
                "REJECTED" => AppAssetLibraryVideoAttributesDiscriminatorState.Rejected,
                "UPLOAD_COMPLETE" => AppAssetLibraryVideoAttributesDiscriminatorState.UploadComplete,
                "WAITING_FOR_REVIEW" => AppAssetLibraryVideoAttributesDiscriminatorState.WaitingForReview,
                _ => null,
            };
        }
    }
}