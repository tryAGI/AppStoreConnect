
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        CompatibleVersions,
        /// <summary>
        ///
        /// </summary>
        IconAsset,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        VersionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion value)
        {
            return value switch
            {
                AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.App => "app",
                AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.CompatibleVersions => "compatibleVersions",
                AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.IconAsset => "iconAsset",
                AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.Platform => "platform",
                AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.App,
                "compatibleVersions" => AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.CompatibleVersions,
                "iconAsset" => AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.IconAsset,
                "platform" => AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.Platform,
                "versionString" => AppsGameCenterEnabledVersionsGetToManyRelatedFieldsGameCenterEnabledVersion.VersionString,
                _ => null,
            };
        }
    }
}