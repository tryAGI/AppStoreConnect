
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        CompatibilityVersions,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}