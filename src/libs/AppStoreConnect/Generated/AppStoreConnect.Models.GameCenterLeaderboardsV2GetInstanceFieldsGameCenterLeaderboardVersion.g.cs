
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion
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
    public static class GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.State => "state",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.State,
                "version" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}