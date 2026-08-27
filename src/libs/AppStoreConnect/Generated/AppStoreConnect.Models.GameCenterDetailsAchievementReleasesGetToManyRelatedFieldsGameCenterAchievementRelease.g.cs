
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease
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
    public static class GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}