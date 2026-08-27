
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsGameCenterAppVersion
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
    public static class AppStoreVersionsGetInstanceFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGetInstanceFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                AppStoreVersionsGetInstanceFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsGetInstanceFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => AppStoreVersionsGetInstanceFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => AppStoreVersionsGetInstanceFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}