
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsResponseIncludedItemDiscriminatorType
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
    public static class GameCenterLeaderboardsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterChallenges" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                "gameCenterDetails" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardLocalizations,
                "gameCenterLeaderboardReleases" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                "gameCenterLeaderboards" => GameCenterLeaderboardsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}