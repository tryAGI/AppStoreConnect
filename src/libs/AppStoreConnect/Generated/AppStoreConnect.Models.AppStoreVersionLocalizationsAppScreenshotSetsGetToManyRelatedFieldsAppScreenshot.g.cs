
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot
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
    public static class AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet => "appScreenshotSet",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetToken => "assetToken",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetType => "assetType",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileName => "fileName",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileSize => "fileSize",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.ImageAsset => "imageAsset",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet,
                "assetDeliveryState" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState,
                "assetToken" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetToken,
                "assetType" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetType,
                "fileName" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileName,
                "fileSize" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileSize,
                "imageAsset" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.ImageAsset,
                "sourceFileChecksum" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum,
                "uploadOperations" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}