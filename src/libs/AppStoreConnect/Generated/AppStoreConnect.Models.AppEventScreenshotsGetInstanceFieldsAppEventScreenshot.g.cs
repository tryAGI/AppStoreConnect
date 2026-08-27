
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventScreenshotsGetInstanceFieldsAppEventScreenshot
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
        AssetToken,
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
        ImageAsset,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotsGetInstanceFieldsAppEventScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotsGetInstanceFieldsAppEventScreenshot value)
        {
            return value switch
            {
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AppEventAssetType => "appEventAssetType",
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AppEventLocalization => "appEventLocalization",
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AssetToken => "assetToken",
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.FileName => "fileName",
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.FileSize => "fileSize",
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.ImageAsset => "imageAsset",
                AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotsGetInstanceFieldsAppEventScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AppEventAssetType,
                "appEventLocalization" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AppEventLocalization,
                "assetDeliveryState" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AssetDeliveryState,
                "assetToken" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.AssetToken,
                "fileName" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.FileName,
                "fileSize" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.FileSize,
                "imageAsset" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.ImageAsset,
                "uploadOperations" => AppEventScreenshotsGetInstanceFieldsAppEventScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}