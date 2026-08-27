
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsReleasesGetToManyRelatedIncludeItem
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
    public static class GameCenterAchievementsReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementsReleasesGetToManyRelatedIncludeItem.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementsReleasesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementsReleasesGetToManyRelatedIncludeItem.GameCenterAchievement,
                "gameCenterDetail" => GameCenterAchievementsReleasesGetToManyRelatedIncludeItem.GameCenterDetail,
                _ => null,
            };
        }
    }
}