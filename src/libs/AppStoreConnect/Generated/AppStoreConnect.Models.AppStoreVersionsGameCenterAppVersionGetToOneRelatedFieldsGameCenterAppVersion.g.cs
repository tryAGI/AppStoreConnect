
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion
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
    public static class AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}