
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot
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
    public static class AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet => "appScreenshotSet",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetToken => "assetToken",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetType => "assetType",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileName => "fileName",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileSize => "fileSize",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.ImageAsset => "imageAsset",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum => "sourceFileChecksum",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet,
                "assetDeliveryState" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState,
                "assetToken" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetToken,
                "assetType" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetType,
                "fileName" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileName,
                "fileSize" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileSize,
                "imageAsset" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.ImageAsset,
                "sourceFileChecksum" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum,
                "uploadOperations" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}