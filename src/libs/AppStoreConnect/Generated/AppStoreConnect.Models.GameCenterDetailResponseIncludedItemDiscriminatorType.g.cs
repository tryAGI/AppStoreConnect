
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailResponseIncludedItemDiscriminatorType
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
    public static class GameCenterDetailResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterDetailResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                GameCenterDetailResponseIncludedItemDiscriminatorType.Apps => "apps",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterChallenges => "gameCenterChallenges",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => GameCenterDetailResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "apps" => GameCenterDetailResponseIncludedItemDiscriminatorType.Apps,
                "gameCenterAchievementReleases" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases,
                "gameCenterAchievements" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterActivities" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterActivityVersionReleases" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases,
                "gameCenterAppVersions" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterAppVersions,
                "gameCenterChallengeVersionReleases" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases,
                "gameCenterChallenges" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterChallenges,
                "gameCenterGroups" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboardReleases" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardReleases,
                "gameCenterLeaderboardSetReleases" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetReleases,
                "gameCenterLeaderboardSets" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                "gameCenterLeaderboards" => GameCenterDetailResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}