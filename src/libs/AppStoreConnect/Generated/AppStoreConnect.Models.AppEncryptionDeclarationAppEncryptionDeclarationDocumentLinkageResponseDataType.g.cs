
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationAppEncryptionDeclarationDocumentLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarationDocuments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationAppEncryptionDeclarationDocumentLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationAppEncryptionDeclarationDocumentLinkageResponseDataType value)
        {
            return value switch
            {
                AppEncryptionDeclarationAppEncryptionDeclarationDocumentLinkageResponseDataType.AppEncryptionDeclarationDocuments => "appEncryptionDeclarationDocuments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationAppEncryptionDeclarationDocumentLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarationDocuments" => AppEncryptionDeclarationAppEncryptionDeclarationDocumentLinkageResponseDataType.AppEncryptionDeclarationDocuments,
                _ => null,
            };
        }
    }
}