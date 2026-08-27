
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail
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
    public static class GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.App => "app",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}