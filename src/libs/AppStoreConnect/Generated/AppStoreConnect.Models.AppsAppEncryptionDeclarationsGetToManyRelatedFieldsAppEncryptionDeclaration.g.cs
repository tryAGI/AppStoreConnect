
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration
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
    public static class AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.App => "app",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.Builds => "builds",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.Exempt => "exempt",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.Platform => "platform",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.App,
                "appDescription" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.Exempt,
                "platform" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}