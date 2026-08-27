
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievement,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem.GameCenterAchievement => "gameCenterAchievement",
                GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem.GameCenterAchievement,
                "gameCenterDetail" => GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem.GameCenterDetail,
                _ => null,
            };
        }
    }
}