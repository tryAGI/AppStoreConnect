
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip
    {
        /// <summary>
        /// 
        /// </summary>
        AppEventAssetType,
        /// <summary>
        /// 
        /// </summary>
        AppEventLocalization,
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
    public static class AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip value)
        {
            return value switch
            {
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.AppEventAssetType => "appEventAssetType",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.AppEventLocalization => "appEventLocalization",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.AssetDeliveryState => "assetDeliveryState",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.FileName => "fileName",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.FileSize => "fileSize",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameImage => "previewFrameImage",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.PreviewImage => "previewImage",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.UploadOperations => "uploadOperations",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.VideoDeliveryState => "videoDeliveryState",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.AppEventAssetType,
                "appEventLocalization" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.AppEventLocalization,
                "assetDeliveryState" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.AssetDeliveryState,
                "fileName" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.FileName,
                "fileSize" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.FileSize,
                "previewFrameImage" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameImage,
                "previewFrameTimeCode" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameTimeCode,
                "previewImage" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.PreviewImage,
                "uploadOperations" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.UploadOperations,
                "videoDeliveryState" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.VideoDeliveryState,
                "videoUrl" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventVideoClip.VideoUrl,
                _ => null,
            };
        }
    }
}