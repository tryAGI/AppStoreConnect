
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}