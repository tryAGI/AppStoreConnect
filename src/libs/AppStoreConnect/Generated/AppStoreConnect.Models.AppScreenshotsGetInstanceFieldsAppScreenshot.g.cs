
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotsGetInstanceFieldsAppScreenshot
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshotSet,
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
        AssetType,
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
        SourceFileChecksum,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotsGetInstanceFieldsAppScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotsGetInstanceFieldsAppScreenshot value)
        {
            return value switch
            {
                AppScreenshotsGetInstanceFieldsAppScreenshot.AppScreenshotSet => "appScreenshotSet",
                AppScreenshotsGetInstanceFieldsAppScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppScreenshotsGetInstanceFieldsAppScreenshot.AssetToken => "assetToken",
                AppScreenshotsGetInstanceFieldsAppScreenshot.AssetType => "assetType",
                AppScreenshotsGetInstanceFieldsAppScreenshot.FileName => "fileName",
                AppScreenshotsGetInstanceFieldsAppScreenshot.FileSize => "fileSize",
                AppScreenshotsGetInstanceFieldsAppScreenshot.ImageAsset => "imageAsset",
                AppScreenshotsGetInstanceFieldsAppScreenshot.SourceFileChecksum => "sourceFileChecksum",
                AppScreenshotsGetInstanceFieldsAppScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotsGetInstanceFieldsAppScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppScreenshotsGetInstanceFieldsAppScreenshot.AppScreenshotSet,
                "assetDeliveryState" => AppScreenshotsGetInstanceFieldsAppScreenshot.AssetDeliveryState,
                "assetToken" => AppScreenshotsGetInstanceFieldsAppScreenshot.AssetToken,
                "assetType" => AppScreenshotsGetInstanceFieldsAppScreenshot.AssetType,
                "fileName" => AppScreenshotsGetInstanceFieldsAppScreenshot.FileName,
                "fileSize" => AppScreenshotsGetInstanceFieldsAppScreenshot.FileSize,
                "imageAsset" => AppScreenshotsGetInstanceFieldsAppScreenshot.ImageAsset,
                "sourceFileChecksum" => AppScreenshotsGetInstanceFieldsAppScreenshot.SourceFileChecksum,
                "uploadOperations" => AppScreenshotsGetInstanceFieldsAppScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}