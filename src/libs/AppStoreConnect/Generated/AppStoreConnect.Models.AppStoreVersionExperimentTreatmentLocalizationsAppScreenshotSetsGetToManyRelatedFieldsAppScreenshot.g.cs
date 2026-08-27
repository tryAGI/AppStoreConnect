
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet => "appScreenshotSet",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetToken => "assetToken",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetType => "assetType",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileName => "fileName",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileSize => "fileSize",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.ImageAsset => "imageAsset",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AppScreenshotSet,
                "assetDeliveryState" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetDeliveryState,
                "assetToken" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetToken,
                "assetType" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.AssetType,
                "fileName" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileName,
                "fileSize" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.FileSize,
                "imageAsset" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.ImageAsset,
                "sourceFileChecksum" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.SourceFileChecksum,
                "uploadOperations" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}