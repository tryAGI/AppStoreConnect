
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview
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
    public static class AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AppPreviewSet => "appPreviewSet",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AssetDeliveryState => "assetDeliveryState",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileName => "fileName",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileSize => "fileSize",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.MimeType => "mimeType",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameImage => "previewFrameImage",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewImage => "previewImage",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.UploadOperations => "uploadOperations",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoDeliveryState => "videoDeliveryState",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSet" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AppPreviewSet,
                "assetDeliveryState" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AssetDeliveryState,
                "fileName" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileName,
                "fileSize" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileSize,
                "mimeType" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.MimeType,
                "previewFrameImage" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameImage,
                "previewFrameTimeCode" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameTimeCode,
                "previewImage" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewImage,
                "sourceFileChecksum" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.SourceFileChecksum,
                "uploadOperations" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.UploadOperations,
                "videoDeliveryState" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoDeliveryState,
                "videoUrl" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoUrl,
                _ => null,
            };
        }
    }
}