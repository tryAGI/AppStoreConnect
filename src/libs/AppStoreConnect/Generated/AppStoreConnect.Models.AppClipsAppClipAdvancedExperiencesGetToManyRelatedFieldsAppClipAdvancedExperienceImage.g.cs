
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage
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
    public static class AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage value)
        {
            return value switch
            {
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.AssetDeliveryState => "assetDeliveryState",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.FileName => "fileName",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.FileSize => "fileSize",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.ImageAsset => "imageAsset",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.SourceFileChecksum => "sourceFileChecksum",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.AssetDeliveryState,
                "fileName" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.FileName,
                "fileSize" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.FileSize,
                "imageAsset" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.ImageAsset,
                "sourceFileChecksum" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.SourceFileChecksum,
                "uploadOperations" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage.UploadOperations,
                _ => null,
            };
        }
    }
}