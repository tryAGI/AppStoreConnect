
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage
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
    public static class AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage value)
        {
            return value switch
            {
                AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization => "appClipDefaultExperienceLocalization",
                AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.AssetDeliveryState => "assetDeliveryState",
                AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.FileName => "fileName",
                AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.FileSize => "fileSize",
                AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.ImageAsset => "imageAsset",
                AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.SourceFileChecksum => "sourceFileChecksum",
                AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalization" => AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.AppClipDefaultExperienceLocalization,
                "assetDeliveryState" => AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.AssetDeliveryState,
                "fileName" => AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.FileName,
                "fileSize" => AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.FileSize,
                "imageAsset" => AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.ImageAsset,
                "sourceFileChecksum" => AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.SourceFileChecksum,
                "uploadOperations" => AppClipHeaderImagesGetInstanceFieldsAppClipHeaderImage.UploadOperations,
                _ => null,
            };
        }
    }
}