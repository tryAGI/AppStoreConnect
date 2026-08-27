
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsAppEncryptionDeclaration
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
    public static class BuildsGetCollectionFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsAppEncryptionDeclaration.App => "app",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.Builds => "builds",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.Exempt => "exempt",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.Platform => "platform",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                BuildsGetCollectionFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetCollectionFieldsAppEncryptionDeclaration.App,
                "appDescription" => BuildsGetCollectionFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => BuildsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => BuildsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => BuildsGetCollectionFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => BuildsGetCollectionFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => BuildsGetCollectionFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => BuildsGetCollectionFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => BuildsGetCollectionFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => BuildsGetCollectionFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => BuildsGetCollectionFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => BuildsGetCollectionFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => BuildsGetCollectionFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => BuildsGetCollectionFieldsAppEncryptionDeclaration.Exempt,
                "platform" => BuildsGetCollectionFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => BuildsGetCollectionFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => BuildsGetCollectionFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}