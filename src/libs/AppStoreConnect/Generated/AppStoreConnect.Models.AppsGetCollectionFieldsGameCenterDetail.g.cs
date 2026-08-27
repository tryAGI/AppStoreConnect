
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsGameCenterDetail
    {
        /// <summary>
        ///
        /// </summary>
        AchievementReleases,
        /// <summary>
        ///
        /// </summary>
        ActivityReleases,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        ArcadeEnabled,
        /// <summary>
        ///
        /// </summary>
        ChallengeEnabled,
        /// <summary>
        ///
        /// </summary>
        ChallengeReleases,
        /// <summary>
        ///
        /// </summary>
        ChallengesMinimumPlatformVersions,
        /// <summary>
        ///
        /// </summary>
        DefaultGroupLeaderboard,
        /// <summary>
        ///
        /// </summary>
        DefaultGroupLeaderboardV2,
        /// <summary>
        ///
        /// </summary>
        DefaultLeaderboard,
        /// <summary>
        ///
        /// </summary>
        DefaultLeaderboardV2,
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementsV2,
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
        /// <summary>
        ///
        /// </summary>
        GameCenterGroup,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetsV2,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardsV2,
        /// <summary>
        ///
        /// </summary>
        LeaderboardReleases,
        /// <summary>
        ///
        /// </summary>
        LeaderboardSetReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetCollectionFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsGameCenterDetail value)
        {
            return value switch
            {
                AppsGetCollectionFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                AppsGetCollectionFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                AppsGetCollectionFieldsGameCenterDetail.App => "app",
                AppsGetCollectionFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                AppsGetCollectionFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                AppsGetCollectionFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                AppsGetCollectionFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                AppsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                AppsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                AppsGetCollectionFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                AppsGetCollectionFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                AppsGetCollectionFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                AppsGetCollectionFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => AppsGetCollectionFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => AppsGetCollectionFieldsGameCenterDetail.ActivityReleases,
                "app" => AppsGetCollectionFieldsGameCenterDetail.App,
                "arcadeEnabled" => AppsGetCollectionFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => AppsGetCollectionFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => AppsGetCollectionFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => AppsGetCollectionFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => AppsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => AppsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => AppsGetCollectionFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => AppsGetCollectionFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => AppsGetCollectionFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => AppsGetCollectionFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => AppsGetCollectionFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => AppsGetCollectionFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => AppsGetCollectionFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => AppsGetCollectionFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => AppsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => AppsGetCollectionFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => AppsGetCollectionFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}