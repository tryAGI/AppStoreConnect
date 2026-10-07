
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesImagesGetToManyRelatedFilterStateItem
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
    public static class AppAssetLibrariesImagesGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesImagesGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Archived => "ARCHIVED",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.AwaitingUpload => "AWAITING_UPLOAD",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Complete => "COMPLETE",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Failed => "FAILED",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.UploadComplete => "UPLOAD_COMPLETE",
                AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesImagesGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Approved,
                "ARCHIVED" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Archived,
                "AWAITING_UPLOAD" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.AwaitingUpload,
                "COMPLETE" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Complete,
                "FAILED" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Failed,
                "IN_REVIEW" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.Rejected,
                "UPLOAD_COMPLETE" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.UploadComplete,
                "WAITING_FOR_REVIEW" => AppAssetLibrariesImagesGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}