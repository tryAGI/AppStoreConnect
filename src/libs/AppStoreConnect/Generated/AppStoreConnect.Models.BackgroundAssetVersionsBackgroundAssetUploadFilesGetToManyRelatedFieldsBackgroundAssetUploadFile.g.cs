
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile
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
    public static class BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile value)
        {
            return value switch
            {
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetDeliveryState => "assetDeliveryState",
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetToken => "assetToken",
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetType => "assetType",
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.FileName => "fileName",
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.FileSize => "fileSize",
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksum => "sourceFileChecksum",
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksums => "sourceFileChecksums",
                BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetDeliveryState,
                "assetToken" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetToken,
                "assetType" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetType,
                "fileName" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.FileName,
                "fileSize" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.FileSize,
                "sourceFileChecksum" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksum,
                "sourceFileChecksums" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksums,
                "uploadOperations" => BackgroundAssetVersionsBackgroundAssetUploadFilesGetToManyRelatedFieldsBackgroundAssetUploadFile.UploadOperations,
                _ => null,
            };
        }
    }
}