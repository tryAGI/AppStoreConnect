
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease
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
    public static class GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}