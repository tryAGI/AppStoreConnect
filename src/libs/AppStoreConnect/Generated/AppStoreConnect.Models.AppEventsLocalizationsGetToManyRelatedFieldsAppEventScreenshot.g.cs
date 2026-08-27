
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot
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
    public static class AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot value)
        {
            return value switch
            {
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AppEventAssetType => "appEventAssetType",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AppEventLocalization => "appEventLocalization",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AssetToken => "assetToken",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.FileName => "fileName",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.FileSize => "fileSize",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.ImageAsset => "imageAsset",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appEventAssetType" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AppEventAssetType,
                "appEventLocalization" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AppEventLocalization,
                "assetDeliveryState" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AssetDeliveryState,
                "assetToken" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.AssetToken,
                "fileName" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.FileName,
                "fileSize" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.FileSize,
                "imageAsset" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.ImageAsset,
                "uploadOperations" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}