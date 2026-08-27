
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclarationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclarationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclarationDataType value)
        {
            return value switch
            {
                AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclarationDataType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclarationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => AppEncryptionDeclarationDocumentCreateRequestDataRelationshipsAppEncryptionDeclarationDataType.AppEncryptionDeclarations,
                _ => null,
            };
        }
    }
}