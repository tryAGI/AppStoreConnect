
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType
    {
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
        GameCenterGroups,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSets,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterChallenges" => GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                "gameCenterDetails" => GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                "gameCenterLeaderboardVersions" => GameCenterLeaderboardV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}