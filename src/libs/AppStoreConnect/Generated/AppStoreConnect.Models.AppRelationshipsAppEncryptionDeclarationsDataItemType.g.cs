
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsAppEncryptionDeclarationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsAppEncryptionDeclarationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsAppEncryptionDeclarationsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsAppEncryptionDeclarationsDataItemType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsAppEncryptionDeclarationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => AppRelationshipsAppEncryptionDeclarationsDataItemType.AppEncryptionDeclarations,
                _ => null,
            };
        }
    }
}