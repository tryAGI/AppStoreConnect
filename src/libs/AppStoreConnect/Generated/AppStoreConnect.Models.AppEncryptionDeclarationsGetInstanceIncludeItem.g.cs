
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationsGetInstanceIncludeItem
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
    public static class AppEncryptionDeclarationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetInstanceIncludeItem.App => "app",
                AppEncryptionDeclarationsGetInstanceIncludeItem.AppEncryptionDeclarationDocument => "appEncryptionDeclarationDocument",
                AppEncryptionDeclarationsGetInstanceIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppEncryptionDeclarationsGetInstanceIncludeItem.App,
                "appEncryptionDeclarationDocument" => AppEncryptionDeclarationsGetInstanceIncludeItem.AppEncryptionDeclarationDocument,
                "builds" => AppEncryptionDeclarationsGetInstanceIncludeItem.Builds,
                _ => null,
            };
        }
    }
}