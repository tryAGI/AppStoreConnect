
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        LeaderboardSet,
        /// <summary>
        ///
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem.LeaderboardSet => "leaderboardSet",
                GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem.LeaderboardSet,
                "localizations" => GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}