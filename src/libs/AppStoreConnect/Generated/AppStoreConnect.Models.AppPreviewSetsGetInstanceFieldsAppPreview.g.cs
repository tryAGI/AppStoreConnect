
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewSetsGetInstanceFieldsAppPreview
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
    public static class AppPreviewSetsGetInstanceFieldsAppPreviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsGetInstanceFieldsAppPreview value)
        {
            return value switch
            {
                AppPreviewSetsGetInstanceFieldsAppPreview.AppPreviewSet => "appPreviewSet",
                AppPreviewSetsGetInstanceFieldsAppPreview.AssetDeliveryState => "assetDeliveryState",
                AppPreviewSetsGetInstanceFieldsAppPreview.FileName => "fileName",
                AppPreviewSetsGetInstanceFieldsAppPreview.FileSize => "fileSize",
                AppPreviewSetsGetInstanceFieldsAppPreview.MimeType => "mimeType",
                AppPreviewSetsGetInstanceFieldsAppPreview.PreviewFrameImage => "previewFrameImage",
                AppPreviewSetsGetInstanceFieldsAppPreview.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppPreviewSetsGetInstanceFieldsAppPreview.PreviewImage => "previewImage",
                AppPreviewSetsGetInstanceFieldsAppPreview.SourceFileChecksum => "sourceFileChecksum",
                AppPreviewSetsGetInstanceFieldsAppPreview.UploadOperations => "uploadOperations",
                AppPreviewSetsGetInstanceFieldsAppPreview.VideoDeliveryState => "videoDeliveryState",
                AppPreviewSetsGetInstanceFieldsAppPreview.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsGetInstanceFieldsAppPreview? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSet" => AppPreviewSetsGetInstanceFieldsAppPreview.AppPreviewSet,
                "assetDeliveryState" => AppPreviewSetsGetInstanceFieldsAppPreview.AssetDeliveryState,
                "fileName" => AppPreviewSetsGetInstanceFieldsAppPreview.FileName,
                "fileSize" => AppPreviewSetsGetInstanceFieldsAppPreview.FileSize,
                "mimeType" => AppPreviewSetsGetInstanceFieldsAppPreview.MimeType,
                "previewFrameImage" => AppPreviewSetsGetInstanceFieldsAppPreview.PreviewFrameImage,
                "previewFrameTimeCode" => AppPreviewSetsGetInstanceFieldsAppPreview.PreviewFrameTimeCode,
                "previewImage" => AppPreviewSetsGetInstanceFieldsAppPreview.PreviewImage,
                "sourceFileChecksum" => AppPreviewSetsGetInstanceFieldsAppPreview.SourceFileChecksum,
                "uploadOperations" => AppPreviewSetsGetInstanceFieldsAppPreview.UploadOperations,
                "videoDeliveryState" => AppPreviewSetsGetInstanceFieldsAppPreview.VideoDeliveryState,
                "videoUrl" => AppPreviewSetsGetInstanceFieldsAppPreview.VideoUrl,
                _ => null,
            };
        }
    }
}