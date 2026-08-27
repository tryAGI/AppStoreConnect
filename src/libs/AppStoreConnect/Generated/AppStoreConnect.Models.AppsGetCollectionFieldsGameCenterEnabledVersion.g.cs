
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsGameCenterEnabledVersion
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
    public static class AppsGetCollectionFieldsGameCenterEnabledVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsGameCenterEnabledVersion value)
        {
            return value switch
            {
                AppsGetCollectionFieldsGameCenterEnabledVersion.App => "app",
                AppsGetCollectionFieldsGameCenterEnabledVersion.CompatibleVersions => "compatibleVersions",
                AppsGetCollectionFieldsGameCenterEnabledVersion.IconAsset => "iconAsset",
                AppsGetCollectionFieldsGameCenterEnabledVersion.Platform => "platform",
                AppsGetCollectionFieldsGameCenterEnabledVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsGameCenterEnabledVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsGameCenterEnabledVersion.App,
                "compatibleVersions" => AppsGetCollectionFieldsGameCenterEnabledVersion.CompatibleVersions,
                "iconAsset" => AppsGetCollectionFieldsGameCenterEnabledVersion.IconAsset,
                "platform" => AppsGetCollectionFieldsGameCenterEnabledVersion.Platform,
                "versionString" => AppsGetCollectionFieldsGameCenterEnabledVersion.VersionString,
                _ => null,
            };
        }
    }
}