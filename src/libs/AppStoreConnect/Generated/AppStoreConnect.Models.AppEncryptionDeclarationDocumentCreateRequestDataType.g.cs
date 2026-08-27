
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationDocumentCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarationDocuments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationDocumentCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationDocumentCreateRequestDataType value)
        {
            return value switch
            {
                AppEncryptionDeclarationDocumentCreateRequestDataType.AppEncryptionDeclarationDocuments => "appEncryptionDeclarationDocuments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationDocumentCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarationDocuments" => AppEncryptionDeclarationDocumentCreateRequestDataType.AppEncryptionDeclarationDocuments,
                _ => null,
            };
        }
    }
}