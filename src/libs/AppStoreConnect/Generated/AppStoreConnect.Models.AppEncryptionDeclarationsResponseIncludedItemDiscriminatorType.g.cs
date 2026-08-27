
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarationDocuments,
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType.AppEncryptionDeclarationDocuments => "appEncryptionDeclarationDocuments",
                AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType.Apps => "apps",
                AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarationDocuments" => AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType.AppEncryptionDeclarationDocuments,
                "apps" => AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType.Apps,
                "builds" => AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}