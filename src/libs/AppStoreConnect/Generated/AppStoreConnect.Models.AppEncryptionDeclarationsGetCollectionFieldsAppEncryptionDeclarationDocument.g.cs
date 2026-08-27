
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument
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
        DownloadUrl,
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
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocumentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.AssetDeliveryState => "assetDeliveryState",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.AssetToken => "assetToken",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.DownloadUrl => "downloadUrl",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.FileName => "fileName",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.FileSize => "fileSize",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.SourceFileChecksum => "sourceFileChecksum",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.AssetDeliveryState,
                "assetToken" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.AssetToken,
                "downloadUrl" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.DownloadUrl,
                "fileName" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.FileName,
                "fileSize" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.FileSize,
                "sourceFileChecksum" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.SourceFileChecksum,
                "uploadOperations" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument.UploadOperations,
                _ => null,
            };
        }
    }
}