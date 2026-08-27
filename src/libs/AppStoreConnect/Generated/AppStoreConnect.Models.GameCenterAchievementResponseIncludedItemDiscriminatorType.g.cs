
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementResponseIncludedItemDiscriminatorType
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
    public static class GameCenterAchievementResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations,
                "gameCenterAchievementReleases" => GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterAchievementReleases,
                "gameCenterAchievements" => GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterActivities" => GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterDetails" => GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterAchievementResponseIncludedItemDiscriminatorType.GameCenterGroups,
                _ => null,
            };
        }
    }
}