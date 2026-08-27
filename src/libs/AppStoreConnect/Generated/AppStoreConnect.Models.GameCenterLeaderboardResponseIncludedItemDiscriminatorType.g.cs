
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardResponseIncludedItemDiscriminatorType
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
        GameCenterLeaderboardLocalizations,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardReleases,
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
    public static class GameCenterLeaderboardResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterChallenges" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                "gameCenterDetails" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboardLocalizations,
                "gameCenterLeaderboardReleases" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                "gameCenterLeaderboards" => GameCenterLeaderboardResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}