
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile
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
    public static class BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile value)
        {
            return value switch
            {
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.AssetDeliveryState => "assetDeliveryState",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.AssetToken => "assetToken",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.AssetType => "assetType",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.FileName => "fileName",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.FileSize => "fileSize",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksum => "sourceFileChecksum",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksums => "sourceFileChecksums",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.AssetDeliveryState,
                "assetToken" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.AssetToken,
                "assetType" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.AssetType,
                "fileName" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.FileName,
                "fileSize" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.FileSize,
                "sourceFileChecksum" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksum,
                "sourceFileChecksums" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.SourceFileChecksums,
                "uploadOperations" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile.UploadOperations,
                _ => null,
            };
        }
    }
}