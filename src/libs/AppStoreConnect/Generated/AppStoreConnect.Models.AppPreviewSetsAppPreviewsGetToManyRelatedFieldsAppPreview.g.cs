
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview
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
    public static class AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview value)
        {
            return value switch
            {
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.AppPreviewSet => "appPreviewSet",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.AssetDeliveryState => "assetDeliveryState",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.FileName => "fileName",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.FileSize => "fileSize",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.MimeType => "mimeType",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.PreviewFrameImage => "previewFrameImage",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.PreviewImage => "previewImage",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.SourceFileChecksum => "sourceFileChecksum",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.UploadOperations => "uploadOperations",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.VideoDeliveryState => "videoDeliveryState",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSet" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.AppPreviewSet,
                "assetDeliveryState" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.AssetDeliveryState,
                "fileName" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.FileName,
                "fileSize" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.FileSize,
                "mimeType" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.MimeType,
                "previewFrameImage" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.PreviewFrameImage,
                "previewFrameTimeCode" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.PreviewFrameTimeCode,
                "previewImage" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.PreviewImage,
                "sourceFileChecksum" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.SourceFileChecksum,
                "uploadOperations" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.UploadOperations,
                "videoDeliveryState" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.VideoDeliveryState,
                "videoUrl" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview.VideoUrl,
                _ => null,
            };
        }
    }
}