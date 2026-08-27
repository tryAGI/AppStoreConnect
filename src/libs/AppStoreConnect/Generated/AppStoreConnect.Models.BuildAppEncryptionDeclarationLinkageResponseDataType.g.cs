
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildAppEncryptionDeclarationLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildAppEncryptionDeclarationLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildAppEncryptionDeclarationLinkageResponseDataType value)
        {
            return value switch
            {
                BuildAppEncryptionDeclarationLinkageResponseDataType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildAppEncryptionDeclarationLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => BuildAppEncryptionDeclarationLinkageResponseDataType.AppEncryptionDeclarations,
                _ => null,
            };
        }
    }
}