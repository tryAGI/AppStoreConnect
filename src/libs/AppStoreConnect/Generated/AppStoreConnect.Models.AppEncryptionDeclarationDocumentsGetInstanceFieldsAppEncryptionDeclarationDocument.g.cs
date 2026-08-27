
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument
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
    public static class AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocumentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument value)
        {
            return value switch
            {
                AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetDeliveryState => "assetDeliveryState",
                AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetToken => "assetToken",
                AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.DownloadUrl => "downloadUrl",
                AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.FileName => "fileName",
                AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.FileSize => "fileSize",
                AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.SourceFileChecksum => "sourceFileChecksum",
                AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetDeliveryState,
                "assetToken" => AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetToken,
                "downloadUrl" => AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.DownloadUrl,
                "fileName" => AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.FileName,
                "fileSize" => AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.FileSize,
                "sourceFileChecksum" => AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.SourceFileChecksum,
                "uploadOperations" => AppEncryptionDeclarationDocumentsGetInstanceFieldsAppEncryptionDeclarationDocument.UploadOperations,
                _ => null,
            };
        }
    }
}