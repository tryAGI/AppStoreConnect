
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.App => "app",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.Builds => "builds",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.Exempt => "exempt",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.Platform => "platform",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.App,
                "appDescription" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.Exempt,
                "platform" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}