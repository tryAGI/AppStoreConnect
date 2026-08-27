
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview
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
    public static class AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AppPreviewSet => "appPreviewSet",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AssetDeliveryState => "assetDeliveryState",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileName => "fileName",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileSize => "fileSize",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.MimeType => "mimeType",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameImage => "previewFrameImage",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewImage => "previewImage",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.SourceFileChecksum => "sourceFileChecksum",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.UploadOperations => "uploadOperations",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoDeliveryState => "videoDeliveryState",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSet" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AppPreviewSet,
                "assetDeliveryState" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.AssetDeliveryState,
                "fileName" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileName,
                "fileSize" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.FileSize,
                "mimeType" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.MimeType,
                "previewFrameImage" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameImage,
                "previewFrameTimeCode" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewFrameTimeCode,
                "previewImage" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.PreviewImage,
                "sourceFileChecksum" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.SourceFileChecksum,
                "uploadOperations" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.UploadOperations,
                "videoDeliveryState" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoDeliveryState,
                "videoUrl" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview.VideoUrl,
                _ => null,
            };
        }
    }
}