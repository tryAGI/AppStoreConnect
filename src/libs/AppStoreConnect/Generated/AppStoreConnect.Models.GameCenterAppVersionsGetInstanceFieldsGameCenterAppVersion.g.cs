
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion
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
    public static class GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => GameCenterAppVersionsGetInstanceFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}