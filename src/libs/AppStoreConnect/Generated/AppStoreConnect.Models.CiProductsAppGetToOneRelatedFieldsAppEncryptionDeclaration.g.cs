
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration
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
    public static class CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.App => "app",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.Builds => "builds",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.Exempt => "exempt",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.Platform => "platform",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.App,
                "appDescription" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.Exempt,
                "platform" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}