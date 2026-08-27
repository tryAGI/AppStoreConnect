
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage
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
    public static class AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization => "appClipDefaultExperienceLocalization",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.AssetDeliveryState => "assetDeliveryState",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.FileName => "fileName",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.FileSize => "fileSize",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.ImageAsset => "imageAsset",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.SourceFileChecksum => "sourceFileChecksum",
                AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalization" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization,
                "assetDeliveryState" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.AssetDeliveryState,
                "fileName" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.FileName,
                "fileSize" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.FileSize,
                "imageAsset" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.ImageAsset,
                "sourceFileChecksum" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.SourceFileChecksum,
                "uploadOperations" => AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage.UploadOperations,
                _ => null,
            };
        }
    }
}