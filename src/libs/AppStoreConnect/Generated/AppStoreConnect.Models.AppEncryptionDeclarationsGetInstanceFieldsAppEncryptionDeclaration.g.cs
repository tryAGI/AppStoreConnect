
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration
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
    public static class AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.App => "app",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.Builds => "builds",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.Exempt => "exempt",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.Platform => "platform",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.App,
                "appDescription" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.Exempt,
                "platform" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}