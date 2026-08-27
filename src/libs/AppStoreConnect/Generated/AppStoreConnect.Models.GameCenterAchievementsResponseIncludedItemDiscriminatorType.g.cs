
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementLocalizations,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementReleases,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivities,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetails,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations,
                "gameCenterAchievementReleases" => GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases,
                "gameCenterAchievements" => GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterActivities" => GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterDetails" => GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterAchievementsResponseIncludedItemDiscriminatorType.GameCenterGroups,
                _ => null,
            };
        }
    }
}