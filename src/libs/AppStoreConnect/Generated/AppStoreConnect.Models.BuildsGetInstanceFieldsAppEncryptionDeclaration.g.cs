
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsAppEncryptionDeclaration
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
    public static class BuildsGetInstanceFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsAppEncryptionDeclaration.App => "app",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.Builds => "builds",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.Exempt => "exempt",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.Platform => "platform",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                BuildsGetInstanceFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetInstanceFieldsAppEncryptionDeclaration.App,
                "appDescription" => BuildsGetInstanceFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => BuildsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => BuildsGetInstanceFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => BuildsGetInstanceFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => BuildsGetInstanceFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => BuildsGetInstanceFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => BuildsGetInstanceFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => BuildsGetInstanceFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => BuildsGetInstanceFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => BuildsGetInstanceFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => BuildsGetInstanceFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => BuildsGetInstanceFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => BuildsGetInstanceFieldsAppEncryptionDeclaration.Exempt,
                "platform" => BuildsGetInstanceFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => BuildsGetInstanceFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => BuildsGetInstanceFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}