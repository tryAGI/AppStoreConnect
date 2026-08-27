
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationResponseIncludedItemDiscriminatorType
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
    public static class AppEncryptionDeclarationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppEncryptionDeclarationResponseIncludedItemDiscriminatorType.AppEncryptionDeclarationDocuments => "appEncryptionDeclarationDocuments",
                AppEncryptionDeclarationResponseIncludedItemDiscriminatorType.Apps => "apps",
                AppEncryptionDeclarationResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarationDocuments" => AppEncryptionDeclarationResponseIncludedItemDiscriminatorType.AppEncryptionDeclarationDocuments,
                "apps" => AppEncryptionDeclarationResponseIncludedItemDiscriminatorType.Apps,
                "builds" => AppEncryptionDeclarationResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}