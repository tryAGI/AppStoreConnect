
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Leaderboard,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.State => "state",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.State,
                "version" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}