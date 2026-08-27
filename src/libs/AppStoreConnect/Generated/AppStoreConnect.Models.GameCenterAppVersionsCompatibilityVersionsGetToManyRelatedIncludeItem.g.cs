
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem
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
    public static class GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem.CompatibilityVersions => "compatibilityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem.AppStoreVersion,
                "compatibilityVersions" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem.CompatibilityVersions,
                _ => null,
            };
        }
    }
}