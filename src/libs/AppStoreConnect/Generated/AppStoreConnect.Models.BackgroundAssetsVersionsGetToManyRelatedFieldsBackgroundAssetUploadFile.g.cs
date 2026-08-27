
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetDeliveryState => "assetDeliveryState",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetToken => "assetToken",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetType => "assetType",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.FileName => "fileName",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.FileSize => "fileSize",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksum => "sourceFileChecksum",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksums => "sourceFileChecksums",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetDeliveryState,
                "assetToken" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetToken,
                "assetType" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.AssetType,
                "fileName" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.FileName,
                "fileSize" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.FileSize,
                "sourceFileChecksum" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksum,
                "sourceFileChecksums" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.SourceFileChecksums,
                "uploadOperations" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile.UploadOperations,
                _ => null,
            };
        }
    }
}