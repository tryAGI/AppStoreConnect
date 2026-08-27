
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile
    {
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
        SourceFileChecksum,
        /// <summary>
        /// 
        /// </summary>
        SourceFileChecksums,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile value)
        {
            return value switch
            {
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.AssetDeliveryState => "assetDeliveryState",
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.AssetToken => "assetToken",
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.AssetType => "assetType",
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.FileName => "fileName",
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.FileSize => "fileSize",
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksum => "sourceFileChecksum",
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksums => "sourceFileChecksums",
                BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.AssetDeliveryState,
                "assetToken" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.AssetToken,
                "assetType" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.AssetType,
                "fileName" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.FileName,
                "fileSize" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.FileSize,
                "sourceFileChecksum" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksum,
                "sourceFileChecksums" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksums,
                "uploadOperations" => BackgroundAssetUploadFilesGetInstanceFieldsBackgroundAssetUploadFile.UploadOperations,
                _ => null,
            };
        }
    }
}