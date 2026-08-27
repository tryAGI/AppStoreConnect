
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem.CompatibilityVersions => "compatibilityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem.AppStoreVersion,
                "compatibilityVersions" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem.CompatibilityVersions,
                _ => null,
            };
        }
    }
}