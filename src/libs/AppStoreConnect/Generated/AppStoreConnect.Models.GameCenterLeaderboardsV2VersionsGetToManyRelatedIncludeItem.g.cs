
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Leaderboard,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem.Leaderboard => "leaderboard",
                GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem.Leaderboard,
                "localizations" => GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}