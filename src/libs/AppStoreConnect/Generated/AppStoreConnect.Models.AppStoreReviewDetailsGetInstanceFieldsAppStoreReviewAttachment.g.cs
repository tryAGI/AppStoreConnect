
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment
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
    public static class AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment value)
        {
            return value switch
            {
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.AssetDeliveryState => "assetDeliveryState",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.FileName => "fileName",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.FileSize => "fileSize",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.SourceFileChecksum => "sourceFileChecksum",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetail" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.AppStoreReviewDetail,
                "assetDeliveryState" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.AssetDeliveryState,
                "fileName" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.FileName,
                "fileSize" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.FileSize,
                "sourceFileChecksum" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.SourceFileChecksum,
                "uploadOperations" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment.UploadOperations,
                _ => null,
            };
        }
    }
}