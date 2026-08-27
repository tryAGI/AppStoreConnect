
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion
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
    public static class GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.LeaderboardSet => "leaderboardSet",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Localizations => "localizations",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.State => "state",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.LeaderboardSet,
                "localizations" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Localizations,
                "state" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.State,
                "version" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetVersion.Version,
                _ => null,
            };
        }
    }
}