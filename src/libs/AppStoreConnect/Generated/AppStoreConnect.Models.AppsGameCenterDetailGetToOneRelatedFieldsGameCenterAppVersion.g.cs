
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}