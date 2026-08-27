
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventVideoClipsGetInstanceFieldsAppEventVideoClip
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
    public static class AppEventVideoClipsGetInstanceFieldsAppEventVideoClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventVideoClipsGetInstanceFieldsAppEventVideoClip value)
        {
            return value switch
            {
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.AppEventAssetType => "appEventAssetType",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.AppEventLocalization => "appEventLocalization",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.AssetDeliveryState => "assetDeliveryState",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.FileName => "fileName",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.FileSize => "fileSize",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.PreviewFrameImage => "previewFrameImage",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.PreviewImage => "previewImage",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.UploadOperations => "uploadOperations",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.VideoDeliveryState => "videoDeliveryState",
                AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventVideoClipsGetInstanceFieldsAppEventVideoClip? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.AppEventAssetType,
                "appEventLocalization" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.AppEventLocalization,
                "assetDeliveryState" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.AssetDeliveryState,
                "fileName" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.FileName,
                "fileSize" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.FileSize,
                "previewFrameImage" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.PreviewFrameImage,
                "previewFrameTimeCode" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.PreviewFrameTimeCode,
                "previewImage" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.PreviewImage,
                "uploadOperations" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.UploadOperations,
                "videoDeliveryState" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.VideoDeliveryState,
                "videoUrl" => AppEventVideoClipsGetInstanceFieldsAppEventVideoClip.VideoUrl,
                _ => null,
            };
        }
    }
}