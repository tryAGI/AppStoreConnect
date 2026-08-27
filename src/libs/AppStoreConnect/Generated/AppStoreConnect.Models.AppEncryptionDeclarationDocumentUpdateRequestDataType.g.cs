
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationDocumentUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarationDocuments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationDocumentUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationDocumentUpdateRequestDataType value)
        {
            return value switch
            {
                AppEncryptionDeclarationDocumentUpdateRequestDataType.AppEncryptionDeclarationDocuments => "appEncryptionDeclarationDocuments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationDocumentUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarationDocuments" => AppEncryptionDeclarationDocumentUpdateRequestDataType.AppEncryptionDeclarationDocuments,
                _ => null,
            };
        }
    }
}