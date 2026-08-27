
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildAppEncryptionDeclarationLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildAppEncryptionDeclarationLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildAppEncryptionDeclarationLinkageRequestDataType value)
        {
            return value switch
            {
                BuildAppEncryptionDeclarationLinkageRequestDataType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildAppEncryptionDeclarationLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => BuildAppEncryptionDeclarationLinkageRequestDataType.AppEncryptionDeclarations,
                _ => null,
            };
        }
    }
}