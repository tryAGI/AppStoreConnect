
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroup,
        /// <summary>
        /// 
        /// </summary>
        Leaderboard,
        /// <summary>
        /// 
        /// </summary>
        LeaderboardV2,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterChallengesGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterChallengesGetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterChallengesGetInstanceIncludeItem.Leaderboard => "leaderboard",
                GameCenterChallengesGetInstanceIncludeItem.LeaderboardV2 => "leaderboardV2",
                GameCenterChallengesGetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterChallengesGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterChallengesGetInstanceIncludeItem.GameCenterGroup,
                "leaderboard" => GameCenterChallengesGetInstanceIncludeItem.Leaderboard,
                "leaderboardV2" => GameCenterChallengesGetInstanceIncludeItem.LeaderboardV2,
                "versions" => GameCenterChallengesGetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}