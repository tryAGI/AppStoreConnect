
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage
    {
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
    public static class AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage value)
        {
            return value switch
            {
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.AssetDeliveryState => "assetDeliveryState",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.FileName => "fileName",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.FileSize => "fileSize",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.ImageAsset => "imageAsset",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.SourceFileChecksum => "sourceFileChecksum",
                AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.AssetDeliveryState,
                "fileName" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.FileName,
                "fileSize" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.FileSize,
                "imageAsset" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.ImageAsset,
                "sourceFileChecksum" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.SourceFileChecksum,
                "uploadOperations" => AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage.UploadOperations,
                _ => null,
            };
        }
    }
}