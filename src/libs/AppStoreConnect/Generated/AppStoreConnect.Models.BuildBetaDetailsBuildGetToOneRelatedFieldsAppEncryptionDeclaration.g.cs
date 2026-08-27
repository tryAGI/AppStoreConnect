
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.App => "app",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AppDescription => "appDescription",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState => "appEncryptionDeclarationState",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore => "availableOnFrenchStore",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.Builds => "builds",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.CodeValue => "codeValue",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography => "containsProprietaryCryptography",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography => "containsThirdPartyCryptography",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.CreatedDate => "createdDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentName => "documentName",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentType => "documentType",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentUrl => "documentUrl",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.Exempt => "exempt",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.Platform => "platform",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.UploadedDate => "uploadedDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.UsesEncryption => "usesEncryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.App,
                "appDescription" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AppDescription,
                "appEncryptionDeclarationDocument" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationDocument,
                "appEncryptionDeclarationState" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AppEncryptionDeclarationState,
                "availableOnFrenchStore" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.AvailableOnFrenchStore,
                "builds" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.Builds,
                "codeValue" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.CodeValue,
                "containsProprietaryCryptography" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsProprietaryCryptography,
                "containsThirdPartyCryptography" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.ContainsThirdPartyCryptography,
                "createdDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.CreatedDate,
                "documentName" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentName,
                "documentType" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentType,
                "documentUrl" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.DocumentUrl,
                "exempt" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.Exempt,
                "platform" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.Platform,
                "uploadedDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.UploadedDate,
                "usesEncryption" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration.UsesEncryption,
                _ => null,
            };
        }
    }
}