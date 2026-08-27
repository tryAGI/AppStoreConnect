
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAppEncryptionDeclarationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppEncryptionDeclarationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppEncryptionDeclarationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppEncryptionDeclarationsLinkagesResponseDataItemType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppEncryptionDeclarationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => AppAppEncryptionDeclarationsLinkagesResponseDataItemType.AppEncryptionDeclarations,
                _ => null,
            };
        }
    }
}