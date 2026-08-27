
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetCollectionFieldsGameCenterDetail
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
    public static class GameCenterGroupsGetCollectionFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.App => "app",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterGroupsGetCollectionFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterGroupsGetCollectionFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}