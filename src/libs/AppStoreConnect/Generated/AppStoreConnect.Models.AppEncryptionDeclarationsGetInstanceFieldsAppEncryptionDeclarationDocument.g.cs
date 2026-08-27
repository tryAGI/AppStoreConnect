
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument
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
    public static class AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocumentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetDeliveryState => "assetDeliveryState",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetToken => "assetToken",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.DownloadUrl => "downloadUrl",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.FileName => "fileName",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.FileSize => "fileSize",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.SourceFileChecksum => "sourceFileChecksum",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetDeliveryState,
                "assetToken" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.AssetToken,
                "downloadUrl" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.DownloadUrl,
                "fileName" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.FileName,
                "fileSize" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.FileSize,
                "sourceFileChecksum" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.SourceFileChecksum,
                "uploadOperations" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument.UploadOperations,
                _ => null,
            };
        }
    }
}