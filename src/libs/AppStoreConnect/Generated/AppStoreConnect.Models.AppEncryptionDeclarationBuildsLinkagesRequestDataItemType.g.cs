
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEncryptionDeclarationBuildsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationBuildsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationBuildsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                AppEncryptionDeclarationBuildsLinkagesRequestDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationBuildsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppEncryptionDeclarationBuildsLinkagesRequestDataItemType.Builds,
                _ => null,
            };
        }
    }
}