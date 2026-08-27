
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewDetail,
        /// <summary>
        /// 
        /// </summary>
        AssetDeliveryState,
        /// <summary>
        /// 
        /// </summary>
        FileName,
        /// <summary>
        /// 
        /// </summary>
        FileSize,
        /// <summary>
        /// 
        /// </summary>
        SourceFileChecksum,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment value)
        {
            return value switch
            {
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.AssetDeliveryState => "assetDeliveryState",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.FileName => "fileName",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.FileSize => "fileSize",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.SourceFileChecksum => "sourceFileChecksum",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetail" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.AppStoreReviewDetail,
                "assetDeliveryState" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.AssetDeliveryState,
                "fileName" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.FileName,
                "fileSize" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.FileSize,
                "sourceFileChecksum" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.SourceFileChecksum,
                "uploadOperations" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment.UploadOperations,
                _ => null,
            };
        }
    }
}