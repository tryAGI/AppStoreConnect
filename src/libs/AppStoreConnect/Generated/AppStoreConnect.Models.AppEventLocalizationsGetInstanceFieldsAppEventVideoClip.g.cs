
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationsGetInstanceFieldsAppEventVideoClip
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
    public static class AppEventLocalizationsGetInstanceFieldsAppEventVideoClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsGetInstanceFieldsAppEventVideoClip value)
        {
            return value switch
            {
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.AppEventAssetType => "appEventAssetType",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.AppEventLocalization => "appEventLocalization",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.AssetDeliveryState => "assetDeliveryState",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.FileName => "fileName",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.FileSize => "fileSize",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.PreviewFrameImage => "previewFrameImage",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.PreviewImage => "previewImage",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.UploadOperations => "uploadOperations",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.VideoDeliveryState => "videoDeliveryState",
                AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsGetInstanceFieldsAppEventVideoClip? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.AppEventAssetType,
                "appEventLocalization" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.AppEventLocalization,
                "assetDeliveryState" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.AssetDeliveryState,
                "fileName" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.FileName,
                "fileSize" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.FileSize,
                "previewFrameImage" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.PreviewFrameImage,
                "previewFrameTimeCode" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.PreviewFrameTimeCode,
                "previewImage" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.PreviewImage,
                "uploadOperations" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.UploadOperations,
                "videoDeliveryState" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.VideoDeliveryState,
                "videoUrl" => AppEventLocalizationsGetInstanceFieldsAppEventVideoClip.VideoUrl,
                _ => null,
            };
        }
    }
}