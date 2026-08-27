
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationType
    {
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationType value)
        {
            return value switch
            {
                AppEncryptionDeclarationType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => AppEncryptionDeclarationType.AppEncryptionDeclarations,
                _ => null,
            };
        }
    }
}