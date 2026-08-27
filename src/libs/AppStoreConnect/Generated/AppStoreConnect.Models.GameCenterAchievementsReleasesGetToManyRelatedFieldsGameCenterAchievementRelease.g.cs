
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievement,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}