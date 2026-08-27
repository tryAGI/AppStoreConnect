
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardVersionsV2GetInstanceIncludeItem
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
    public static class GameCenterLeaderboardVersionsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionsV2GetInstanceIncludeItem.Leaderboard => "leaderboard",
                GameCenterLeaderboardVersionsV2GetInstanceIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardVersionsV2GetInstanceIncludeItem.Leaderboard,
                "localizations" => GameCenterLeaderboardVersionsV2GetInstanceIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}