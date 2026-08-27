
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage
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
    public static class AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization => "appClipDefaultExperienceLocalization",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.AssetDeliveryState => "assetDeliveryState",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.FileName => "fileName",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.FileSize => "fileSize",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.ImageAsset => "imageAsset",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.SourceFileChecksum => "sourceFileChecksum",
                AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalization" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization,
                "assetDeliveryState" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.AssetDeliveryState,
                "fileName" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.FileName,
                "fileSize" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.FileSize,
                "imageAsset" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.ImageAsset,
                "sourceFileChecksum" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.SourceFileChecksum,
                "uploadOperations" => AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage.UploadOperations,
                _ => null,
            };
        }
    }
}