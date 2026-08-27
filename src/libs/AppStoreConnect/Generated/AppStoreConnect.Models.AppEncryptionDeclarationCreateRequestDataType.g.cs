
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationCreateRequestDataType value)
        {
            return value switch
            {
                AppEncryptionDeclarationCreateRequestDataType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => AppEncryptionDeclarationCreateRequestDataType.AppEncryptionDeclarations,
                _ => null,
            };
        }
    }
}