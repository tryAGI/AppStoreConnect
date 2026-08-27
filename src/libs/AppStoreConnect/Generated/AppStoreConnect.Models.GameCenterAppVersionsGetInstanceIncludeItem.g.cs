
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        CompatibilityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAppVersionsGetInstanceIncludeItem.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsGetInstanceIncludeItem.CompatibilityVersions => "compatibilityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterAppVersionsGetInstanceIncludeItem.AppStoreVersion,
                "compatibilityVersions" => GameCenterAppVersionsGetInstanceIncludeItem.CompatibilityVersions,
                _ => null,
            };
        }
    }
}