
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion
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
    public static class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}