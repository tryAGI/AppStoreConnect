
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip
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
    public static class AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip value)
        {
            return value switch
            {
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.AppEventAssetType => "appEventAssetType",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.AppEventLocalization => "appEventLocalization",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.AssetDeliveryState => "assetDeliveryState",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.FileName => "fileName",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.FileSize => "fileSize",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameImage => "previewFrameImage",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.PreviewImage => "previewImage",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.UploadOperations => "uploadOperations",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.VideoDeliveryState => "videoDeliveryState",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.VideoUrl => "videoUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.AppEventAssetType,
                "appEventLocalization" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.AppEventLocalization,
                "assetDeliveryState" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.AssetDeliveryState,
                "fileName" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.FileName,
                "fileSize" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.FileSize,
                "previewFrameImage" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameImage,
                "previewFrameTimeCode" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.PreviewFrameTimeCode,
                "previewImage" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.PreviewImage,
                "uploadOperations" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.UploadOperations,
                "videoDeliveryState" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.VideoDeliveryState,
                "videoUrl" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip.VideoUrl,
                _ => null,
            };
        }
    }
}