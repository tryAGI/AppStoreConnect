
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease
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
    public static class GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}