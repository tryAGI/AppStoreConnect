
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion
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
    public static class CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.App => "app",
                CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.CompatibleVersions => "compatibleVersions",
                CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.IconAsset => "iconAsset",
                CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.Platform => "platform",
                CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.App,
                "compatibleVersions" => CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.CompatibleVersions,
                "iconAsset" => CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.IconAsset,
                "platform" => CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.Platform,
                "versionString" => CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion.VersionString,
                _ => null,
            };
        }
    }
}