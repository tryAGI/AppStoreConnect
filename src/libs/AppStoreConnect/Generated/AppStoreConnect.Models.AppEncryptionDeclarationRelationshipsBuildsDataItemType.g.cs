
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationRelationshipsBuildsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEncryptionDeclarationRelationshipsBuildsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationRelationshipsBuildsDataItemType value)
        {
            return value switch
            {
                AppEncryptionDeclarationRelationshipsBuildsDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationRelationshipsBuildsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppEncryptionDeclarationRelationshipsBuildsDataItemType.Builds,
                _ => null,
            };
        }
    }
}