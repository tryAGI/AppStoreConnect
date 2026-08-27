
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument
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
    public static class AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocumentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument value)
        {
            return value switch
            {
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.AssetDeliveryState => "assetDeliveryState",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.AssetToken => "assetToken",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.DownloadUrl => "downloadUrl",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.FileName => "fileName",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.FileSize => "fileSize",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.SourceFileChecksum => "sourceFileChecksum",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.AssetDeliveryState,
                "assetToken" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.AssetToken,
                "downloadUrl" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.DownloadUrl,
                "fileName" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.FileName,
                "fileSize" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.FileSize,
                "sourceFileChecksum" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.SourceFileChecksum,
                "uploadOperations" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument.UploadOperations,
                _ => null,
            };
        }
    }
}