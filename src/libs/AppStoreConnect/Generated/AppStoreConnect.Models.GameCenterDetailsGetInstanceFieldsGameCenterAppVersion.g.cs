
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterAppVersion
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
    public static class GameCenterDetailsGetInstanceFieldsGameCenterAppVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterAppVersion value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterAppVersion.AppStoreVersion => "appStoreVersion",
                GameCenterDetailsGetInstanceFieldsGameCenterAppVersion.CompatibilityVersions => "compatibilityVersions",
                GameCenterDetailsGetInstanceFieldsGameCenterAppVersion.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterAppVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterDetailsGetInstanceFieldsGameCenterAppVersion.AppStoreVersion,
                "compatibilityVersions" => GameCenterDetailsGetInstanceFieldsGameCenterAppVersion.CompatibilityVersions,
                "enabled" => GameCenterDetailsGetInstanceFieldsGameCenterAppVersion.Enabled,
                _ => null,
            };
        }
    }
}