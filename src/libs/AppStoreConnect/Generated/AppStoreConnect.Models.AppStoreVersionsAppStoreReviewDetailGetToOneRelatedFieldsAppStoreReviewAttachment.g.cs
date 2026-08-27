
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment
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
    public static class AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.AssetDeliveryState => "assetDeliveryState",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.FileName => "fileName",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.FileSize => "fileSize",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetail" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.AppStoreReviewDetail,
                "assetDeliveryState" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.AssetDeliveryState,
                "fileName" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.FileName,
                "fileSize" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.FileSize,
                "sourceFileChecksum" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.SourceFileChecksum,
                "uploadOperations" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment.UploadOperations,
                _ => null,
            };
        }
    }
}