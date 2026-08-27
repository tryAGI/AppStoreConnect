
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot
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
    public static class AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot value)
        {
            return value switch
            {
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet => "appScreenshotSet",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AssetToken => "assetToken",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AssetType => "assetType",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.FileName => "fileName",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.FileSize => "fileSize",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.ImageAsset => "imageAsset",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum => "sourceFileChecksum",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet,
                "assetDeliveryState" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState,
                "assetToken" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AssetToken,
                "assetType" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.AssetType,
                "fileName" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.FileName,
                "fileSize" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.FileSize,
                "imageAsset" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.ImageAsset,
                "sourceFileChecksum" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum,
                "uploadOperations" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}