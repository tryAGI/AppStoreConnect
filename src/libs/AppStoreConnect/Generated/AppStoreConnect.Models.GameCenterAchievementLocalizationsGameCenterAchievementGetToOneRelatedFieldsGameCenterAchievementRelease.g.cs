
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease
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
    public static class GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}