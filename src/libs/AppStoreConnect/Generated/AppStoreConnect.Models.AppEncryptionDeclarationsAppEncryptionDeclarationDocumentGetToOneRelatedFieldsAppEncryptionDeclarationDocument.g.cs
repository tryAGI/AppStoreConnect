
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument
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
    public static class AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocumentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument value)
        {
            return value switch
            {
                AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.AssetDeliveryState => "assetDeliveryState",
                AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.AssetToken => "assetToken",
                AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.DownloadUrl => "downloadUrl",
                AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.FileName => "fileName",
                AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.FileSize => "fileSize",
                AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.SourceFileChecksum => "sourceFileChecksum",
                AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.AssetDeliveryState,
                "assetToken" => AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.AssetToken,
                "downloadUrl" => AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.DownloadUrl,
                "fileName" => AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.FileName,
                "fileSize" => AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.FileSize,
                "sourceFileChecksum" => AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.SourceFileChecksum,
                "uploadOperations" => AppEncryptionDeclarationsAppEncryptionDeclarationDocumentGetToOneRelatedFieldsAppEncryptionDeclarationDocument.UploadOperations,
                _ => null,
            };
        }
    }
}