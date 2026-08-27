
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration
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
    public static class AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.App => "app",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.Builds => "builds",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.Exempt => "exempt",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.Platform => "platform",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.App,
                "appDescription" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.Exempt,
                "platform" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}