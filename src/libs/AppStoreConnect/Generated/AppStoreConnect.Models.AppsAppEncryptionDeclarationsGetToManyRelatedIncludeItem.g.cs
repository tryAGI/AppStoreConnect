
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarationDocument,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem.App => "app",
                AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem.App,
                "appEncryptionDeclarationDocument" => AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem.AppEncryptionDeclarationDocument,
                "builds" => AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem.Builds,
                _ => null,
            };
        }
    }
}