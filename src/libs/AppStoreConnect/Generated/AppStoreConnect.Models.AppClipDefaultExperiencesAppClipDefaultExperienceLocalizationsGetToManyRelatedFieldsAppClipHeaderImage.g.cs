
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperienceLocalization,
        /// <summary>
        ///
        /// </summary>
        AssetDeliveryState,
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
    public static class AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage value)
        {
            return value switch
            {
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization => "appClipDefaultExperienceLocalization",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.AssetDeliveryState => "assetDeliveryState",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.FileName => "fileName",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.FileSize => "fileSize",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.ImageAsset => "imageAsset",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.SourceFileChecksum => "sourceFileChecksum",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalization" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization,
                "assetDeliveryState" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.AssetDeliveryState,
                "fileName" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.FileName,
                "fileSize" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.FileSize,
                "imageAsset" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.ImageAsset,
                "sourceFileChecksum" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.SourceFileChecksum,
                "uploadOperations" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage.UploadOperations,
                _ => null,
            };
        }
    }
}