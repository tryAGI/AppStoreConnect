
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}