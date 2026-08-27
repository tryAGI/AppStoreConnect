
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion
    {
        /// <summary>
        ///
        /// </summary>
        LeaderboardSet,
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
    public static class GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.LeaderboardSet => "leaderboardSet",
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Localizations => "localizations",
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.State => "state",
                GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.LeaderboardSet,
                "localizations" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Localizations,
                "state" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.State,
                "version" => GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Version,
                _ => null,
            };
        }
    }
}