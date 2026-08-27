
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.Leaderboard => "leaderboard",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.LeaderboardV2 => "leaderboardV2",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterGroup,
                "leaderboard" => GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.Leaderboard,
                "leaderboardV2" => GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.LeaderboardV2,
                "versions" => GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}