
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        CompatibleVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem.App => "app",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem.CompatibleVersions => "compatibleVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem.App,
                "compatibleVersions" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedIncludeItem.CompatibleVersions,
                _ => null,
            };
        }
    }
}