
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationDocumentType
    {
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarationDocuments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationDocumentType value)
        {
            return value switch
            {
                AppEncryptionDeclarationDocumentType.AppEncryptionDeclarationDocuments => "appEncryptionDeclarationDocuments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarationDocuments" => AppEncryptionDeclarationDocumentType.AppEncryptionDeclarationDocuments,
                _ => null,
            };
        }
    }
}