
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationsGetCollectionIncludeItem
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
    public static class AppEncryptionDeclarationsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetCollectionIncludeItem value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetCollectionIncludeItem.App => "app",
                AppEncryptionDeclarationsGetCollectionIncludeItem.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppEncryptionDeclarationsGetCollectionIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppEncryptionDeclarationsGetCollectionIncludeItem.App,
                "appEncryptionDeclarationDocument" => AppEncryptionDeclarationsGetCollectionIncludeItem.AppEncryptionDeclarationDocument,
                "builds" => AppEncryptionDeclarationsGetCollectionIncludeItem.Builds,
                _ => null,
            };
        }
    }
}