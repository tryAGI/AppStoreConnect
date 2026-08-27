
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail
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
    public static class GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.App => "app",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}