
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievement,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem.GameCenterAchievementImage => "gameCenterAchievementImage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterAchievementsLocalizationsGetToManyRelatedIncludeItem.GameCenterAchievementImage,
                _ => null,
            };
        }
    }
}