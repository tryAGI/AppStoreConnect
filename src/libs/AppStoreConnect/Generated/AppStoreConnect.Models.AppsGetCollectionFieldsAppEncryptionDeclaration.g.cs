
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsAppEncryptionDeclaration
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
    public static class AppsGetCollectionFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAppEncryptionDeclaration.App => "app",
                AppsGetCollectionFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                AppsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                AppsGetCollectionFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                AppsGetCollectionFieldsAppEncryptionDeclaration.Builds => "builds",
                AppsGetCollectionFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                AppsGetCollectionFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                AppsGetCollectionFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                AppsGetCollectionFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                AppsGetCollectionFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                AppsGetCollectionFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                AppsGetCollectionFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                AppsGetCollectionFieldsAppEncryptionDeclaration.Exempt => "exempt",
                AppsGetCollectionFieldsAppEncryptionDeclaration.Platform => "platform",
                AppsGetCollectionFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                AppsGetCollectionFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsAppEncryptionDeclaration.App,
                "appDescription" => AppsGetCollectionFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => AppsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => AppsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => AppsGetCollectionFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => AppsGetCollectionFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => AppsGetCollectionFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => AppsGetCollectionFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => AppsGetCollectionFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => AppsGetCollectionFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => AppsGetCollectionFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => AppsGetCollectionFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => AppsGetCollectionFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => AppsGetCollectionFieldsAppEncryptionDeclaration.Exempt,
                "platform" => AppsGetCollectionFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => AppsGetCollectionFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => AppsGetCollectionFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}