
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail
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
    public static class GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.App => "app",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}