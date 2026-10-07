
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesVideosGetToManyRelatedFilterStateItem
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
    public static class AppAssetLibrariesVideosGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesVideosGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Archived => "ARCHIVED",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.AwaitingUpload => "AWAITING_UPLOAD",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Complete => "COMPLETE",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Failed => "FAILED",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.UploadComplete => "UPLOAD_COMPLETE",
                AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesVideosGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Approved,
                "ARCHIVED" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Archived,
                "AWAITING_UPLOAD" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.AwaitingUpload,
                "COMPLETE" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Complete,
                "FAILED" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Failed,
                "IN_REVIEW" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.Rejected,
                "UPLOAD_COMPLETE" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.UploadComplete,
                "WAITING_FOR_REVIEW" => AppAssetLibrariesVideosGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}