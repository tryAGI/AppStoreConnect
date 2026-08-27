
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage
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
    public static class AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage value)
        {
            return value switch
            {
                AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.AssetDeliveryState => "assetDeliveryState",
                AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.FileName => "fileName",
                AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.FileSize => "fileSize",
                AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.ImageAsset => "imageAsset",
                AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.SourceFileChecksum => "sourceFileChecksum",
                AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.AssetDeliveryState,
                "fileName" => AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.FileName,
                "fileSize" => AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.FileSize,
                "imageAsset" => AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.ImageAsset,
                "sourceFileChecksum" => AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.SourceFileChecksum,
                "uploadOperations" => AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage.UploadOperations,
                _ => null,
            };
        }
    }
}