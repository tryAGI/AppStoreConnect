
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImageAttributesDiscriminatorState
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
    public static class AppAssetLibraryImageAttributesDiscriminatorStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImageAttributesDiscriminatorState value)
        {
            return value switch
            {
                AppAssetLibraryImageAttributesDiscriminatorState.Accepted => "ACCEPTED",
                AppAssetLibraryImageAttributesDiscriminatorState.Approved => "APPROVED",
                AppAssetLibraryImageAttributesDiscriminatorState.Archived => "ARCHIVED",
                AppAssetLibraryImageAttributesDiscriminatorState.AwaitingUpload => "AWAITING_UPLOAD",
                AppAssetLibraryImageAttributesDiscriminatorState.Complete => "COMPLETE",
                AppAssetLibraryImageAttributesDiscriminatorState.Failed => "FAILED",
                AppAssetLibraryImageAttributesDiscriminatorState.InReview => "IN_REVIEW",
                AppAssetLibraryImageAttributesDiscriminatorState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppAssetLibraryImageAttributesDiscriminatorState.ReadyForReview => "READY_FOR_REVIEW",
                AppAssetLibraryImageAttributesDiscriminatorState.Rejected => "REJECTED",
                AppAssetLibraryImageAttributesDiscriminatorState.UploadComplete => "UPLOAD_COMPLETE",
                AppAssetLibraryImageAttributesDiscriminatorState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImageAttributesDiscriminatorState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppAssetLibraryImageAttributesDiscriminatorState.Accepted,
                "APPROVED" => AppAssetLibraryImageAttributesDiscriminatorState.Approved,
                "ARCHIVED" => AppAssetLibraryImageAttributesDiscriminatorState.Archived,
                "AWAITING_UPLOAD" => AppAssetLibraryImageAttributesDiscriminatorState.AwaitingUpload,
                "COMPLETE" => AppAssetLibraryImageAttributesDiscriminatorState.Complete,
                "FAILED" => AppAssetLibraryImageAttributesDiscriminatorState.Failed,
                "IN_REVIEW" => AppAssetLibraryImageAttributesDiscriminatorState.InReview,
                "PREPARE_FOR_SUBMISSION" => AppAssetLibraryImageAttributesDiscriminatorState.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppAssetLibraryImageAttributesDiscriminatorState.ReadyForReview,
                "REJECTED" => AppAssetLibraryImageAttributesDiscriminatorState.Rejected,
                "UPLOAD_COMPLETE" => AppAssetLibraryImageAttributesDiscriminatorState.UploadComplete,
                "WAITING_FOR_REVIEW" => AppAssetLibraryImageAttributesDiscriminatorState.WaitingForReview,
                _ => null,
            };
        }
    }
}