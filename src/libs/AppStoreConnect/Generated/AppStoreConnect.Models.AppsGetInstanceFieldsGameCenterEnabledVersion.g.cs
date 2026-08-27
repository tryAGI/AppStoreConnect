
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsGameCenterEnabledVersion
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
    public static class AppsGetInstanceFieldsGameCenterEnabledVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsGameCenterEnabledVersion value)
        {
            return value switch
            {
                AppsGetInstanceFieldsGameCenterEnabledVersion.App => "app",
                AppsGetInstanceFieldsGameCenterEnabledVersion.CompatibleVersions => "compatibleVersions",
                AppsGetInstanceFieldsGameCenterEnabledVersion.IconAsset => "iconAsset",
                AppsGetInstanceFieldsGameCenterEnabledVersion.Platform => "platform",
                AppsGetInstanceFieldsGameCenterEnabledVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsGameCenterEnabledVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsGameCenterEnabledVersion.App,
                "compatibleVersions" => AppsGetInstanceFieldsGameCenterEnabledVersion.CompatibleVersions,
                "iconAsset" => AppsGetInstanceFieldsGameCenterEnabledVersion.IconAsset,
                "platform" => AppsGetInstanceFieldsGameCenterEnabledVersion.Platform,
                "versionString" => AppsGetInstanceFieldsGameCenterEnabledVersion.VersionString,
                _ => null,
            };
        }
    }
}