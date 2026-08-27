
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsAppEncryptionDeclaration
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
    public static class AppsGetInstanceFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAppEncryptionDeclaration.App => "app",
                AppsGetInstanceFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                AppsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                AppsGetInstanceFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                AppsGetInstanceFieldsAppEncryptionDeclaration.Builds => "builds",
                AppsGetInstanceFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                AppsGetInstanceFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                AppsGetInstanceFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                AppsGetInstanceFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                AppsGetInstanceFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                AppsGetInstanceFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                AppsGetInstanceFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                AppsGetInstanceFieldsAppEncryptionDeclaration.Exempt => "exempt",
                AppsGetInstanceFieldsAppEncryptionDeclaration.Platform => "platform",
                AppsGetInstanceFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                AppsGetInstanceFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsAppEncryptionDeclaration.App,
                "appDescription" => AppsGetInstanceFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => AppsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => AppsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => AppsGetInstanceFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => AppsGetInstanceFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => AppsGetInstanceFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => AppsGetInstanceFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => AppsGetInstanceFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => AppsGetInstanceFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => AppsGetInstanceFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => AppsGetInstanceFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => AppsGetInstanceFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => AppsGetInstanceFieldsAppEncryptionDeclaration.Exempt,
                "platform" => AppsGetInstanceFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => AppsGetInstanceFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => AppsGetInstanceFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}