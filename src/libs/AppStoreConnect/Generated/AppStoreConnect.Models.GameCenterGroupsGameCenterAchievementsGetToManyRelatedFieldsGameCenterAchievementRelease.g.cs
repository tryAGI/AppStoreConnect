
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease
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
    public static class GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}