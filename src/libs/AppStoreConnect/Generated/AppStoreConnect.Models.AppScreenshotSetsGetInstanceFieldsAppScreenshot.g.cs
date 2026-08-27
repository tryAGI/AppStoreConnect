
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotSetsGetInstanceFieldsAppScreenshot
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
    public static class AppScreenshotSetsGetInstanceFieldsAppScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsGetInstanceFieldsAppScreenshot value)
        {
            return value switch
            {
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.AppScreenshotSet => "appScreenshotSet",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.AssetToken => "assetToken",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.AssetType => "assetType",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.FileName => "fileName",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.FileSize => "fileSize",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.ImageAsset => "imageAsset",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.SourceFileChecksum => "sourceFileChecksum",
                AppScreenshotSetsGetInstanceFieldsAppScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsGetInstanceFieldsAppScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.AppScreenshotSet,
                "assetDeliveryState" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.AssetDeliveryState,
                "assetToken" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.AssetToken,
                "assetType" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.AssetType,
                "fileName" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.FileName,
                "fileSize" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.FileSize,
                "imageAsset" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.ImageAsset,
                "sourceFileChecksum" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.SourceFileChecksum,
                "uploadOperations" => AppScreenshotSetsGetInstanceFieldsAppScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}