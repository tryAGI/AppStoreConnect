
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivities,
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallenges,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetails,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSets,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterActivities" => GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterChallenges" => GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                "gameCenterDetails" => GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                "gameCenterLeaderboards" => GameCenterGroupsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}