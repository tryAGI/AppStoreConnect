
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarationDocuments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType value)
        {
            return value switch
            {
                AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType.AppEncryptionDeclarationDocuments => "appEncryptionDeclarationDocuments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarationDocuments" => AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType.AppEncryptionDeclarationDocuments,
                _ => null,
            };
        }
    }
}