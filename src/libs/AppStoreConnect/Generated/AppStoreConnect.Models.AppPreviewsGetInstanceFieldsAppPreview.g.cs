
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewsGetInstanceFieldsAppPreview
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviewSet,
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
        MimeType,
        /// <summary>
        ///
        /// </summary>
        PreviewFrameImage,
        /// <summary>
        ///
        /// </summary>
        PreviewFrameTimeCode,
        /// <summary>
        ///
        /// </summary>
        PreviewImage,
        /// <summary>
        ///
        /// </summary>
        SourceFileChecksum,
        /// <summary>
        ///
        /// </summary>
        UploadOperations,
        /// <summary>
        ///
        /// </summary>
        VideoDeliveryState,
        /// <summary>
        ///
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewsGetInstanceFieldsAppPreviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewsGetInstanceFieldsAppPreview value)
        {
            return value switch
            {
                AppPreviewsGetInstanceFieldsAppPreview.AppPreviewSet => "appPreviewSet",
                AppPreviewsGetInstanceFieldsAppPreview.AssetDeliveryState => "assetDeliveryState",
                AppPreviewsGetInstanceFieldsAppPreview.FileName => "fileName",
                AppPreviewsGetInstanceFieldsAppPreview.FileSize => "fileSize",
                AppPreviewsGetInstanceFieldsAppPreview.MimeType => "mimeType",
                AppPreviewsGetInstanceFieldsAppPreview.PreviewFrameImage => "previewFrameImage",
                AppPreviewsGetInstanceFieldsAppPreview.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppPreviewsGetInstanceFieldsAppPreview.PreviewImage => "previewImage",
                AppPreviewsGetInstanceFieldsAppPreview.SourceFileChecksum => "sourceFileChecksum",
                AppPreviewsGetInstanceFieldsAppPreview.UploadOperations => "uploadOperations",
                AppPreviewsGetInstanceFieldsAppPreview.VideoDeliveryState => "videoDeliveryState",
                AppPreviewsGetInstanceFieldsAppPreview.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewsGetInstanceFieldsAppPreview? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSet" => AppPreviewsGetInstanceFieldsAppPreview.AppPreviewSet,
                "assetDeliveryState" => AppPreviewsGetInstanceFieldsAppPreview.AssetDeliveryState,
                "fileName" => AppPreviewsGetInstanceFieldsAppPreview.FileName,
                "fileSize" => AppPreviewsGetInstanceFieldsAppPreview.FileSize,
                "mimeType" => AppPreviewsGetInstanceFieldsAppPreview.MimeType,
                "previewFrameImage" => AppPreviewsGetInstanceFieldsAppPreview.PreviewFrameImage,
                "previewFrameTimeCode" => AppPreviewsGetInstanceFieldsAppPreview.PreviewFrameTimeCode,
                "previewImage" => AppPreviewsGetInstanceFieldsAppPreview.PreviewImage,
                "sourceFileChecksum" => AppPreviewsGetInstanceFieldsAppPreview.SourceFileChecksum,
                "uploadOperations" => AppPreviewsGetInstanceFieldsAppPreview.UploadOperations,
                "videoDeliveryState" => AppPreviewsGetInstanceFieldsAppPreview.VideoDeliveryState,
                "videoUrl" => AppPreviewsGetInstanceFieldsAppPreview.VideoUrl,
                _ => null,
            };
        }
    }
}