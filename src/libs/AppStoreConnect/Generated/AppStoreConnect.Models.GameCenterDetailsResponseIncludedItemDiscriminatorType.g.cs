
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementReleases,
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
        GameCenterActivityVersionReleases,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAppVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersionReleases,
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallenges,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroups,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardReleases,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetReleases,
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
    public static class GameCenterDetailsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterDetailsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.Apps => "apps",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => GameCenterDetailsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "apps" => GameCenterDetailsResponseIncludedItemDiscriminatorType.Apps,
                "gameCenterAchievementReleases" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases,
                "gameCenterAchievements" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterActivities" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterActivityVersionReleases" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases,
                "gameCenterAppVersions" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterAppVersions,
                "gameCenterChallengeVersionReleases" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases,
                "gameCenterChallenges" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                "gameCenterGroups" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboardReleases" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases,
                "gameCenterLeaderboardSetReleases" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetReleases,
                "gameCenterLeaderboardSets" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                "gameCenterLeaderboards" => GameCenterDetailsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}