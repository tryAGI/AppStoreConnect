
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot
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
    public static class AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot value)
        {
            return value switch
            {
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AppEventAssetType => "appEventAssetType",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AppEventLocalization => "appEventLocalization",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AssetToken => "assetToken",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.FileName => "fileName",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.FileSize => "fileSize",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.ImageAsset => "imageAsset",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AppEventAssetType,
                "appEventLocalization" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AppEventLocalization,
                "assetDeliveryState" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AssetDeliveryState,
                "assetToken" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.AssetToken,
                "fileName" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.FileName,
                "fileSize" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.FileSize,
                "imageAsset" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.ImageAsset,
                "uploadOperations" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}