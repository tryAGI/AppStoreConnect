
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationCreateRequestDataRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationCreateRequestDataRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationCreateRequestDataRelationshipsAppDataType value)
        {
            return value switch
            {
                AppEncryptionDeclarationCreateRequestDataRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationCreateRequestDataRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppEncryptionDeclarationCreateRequestDataRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}