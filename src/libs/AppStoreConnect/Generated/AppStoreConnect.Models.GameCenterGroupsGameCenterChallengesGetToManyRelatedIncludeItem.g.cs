
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem
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
    public static class GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.Leaderboard => "leaderboard",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.LeaderboardV2 => "leaderboardV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.GameCenterGroup,
                "leaderboard" => GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.Leaderboard,
                "leaderboardV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.LeaderboardV2,
                "versions" => GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}