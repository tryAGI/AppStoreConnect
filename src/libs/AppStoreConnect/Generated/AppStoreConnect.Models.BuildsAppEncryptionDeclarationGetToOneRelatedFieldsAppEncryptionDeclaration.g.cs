
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppDescription,
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarationDocument,
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarationState,
        /// <summary>
        ///
        /// </summary>
        AvailableOnFrenchStore,
        /// <summary>
        ///
        /// </summary>
        Builds,
        /// <summary>
        ///
        /// </summary>
        CodeValue,
        /// <summary>
        ///
        /// </summary>
        ContainsProprietaryCryptography,
        /// <summary>
        ///
        /// </summary>
        ContainsThirdPartyCryptography,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        DocumentName,
        /// <summary>
        ///
        /// </summary>
        DocumentType,
        /// <summary>
        ///
        /// </summary>
        DocumentUrl,
        /// <summary>
        ///
        /// </summary>
        Exempt,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        UploadedDate,
        /// <summary>
        ///
        /// </summary>
        UsesEncryption,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.App => "app",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.Builds => "builds",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.Exempt => "exempt",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.Platform => "platform",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.App,
                "appDescription" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.Exempt,
                "platform" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}