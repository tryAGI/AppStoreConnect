
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsGetInstanceFieldsAppEventScreenshot
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
    public static class AppEventLocalizationsGetInstanceFieldsAppEventScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsGetInstanceFieldsAppEventScreenshot value)
        {
            return value switch
            {
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AppEventAssetType => "appEventAssetType",
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AppEventLocalization => "appEventLocalization",
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AssetToken => "assetToken",
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.FileName => "fileName",
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.FileSize => "fileSize",
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.ImageAsset => "imageAsset",
                AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsGetInstanceFieldsAppEventScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AppEventAssetType,
                "appEventLocalization" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AppEventLocalization,
                "assetDeliveryState" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AssetDeliveryState,
                "assetToken" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.AssetToken,
                "fileName" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.FileName,
                "fileSize" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.FileSize,
                "imageAsset" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.ImageAsset,
                "uploadOperations" => AppEventLocalizationsGetInstanceFieldsAppEventScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}