
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Activity,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroup,
        /// <summary>
        /// 
        /// </summary>
        GroupAchievement,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        Releases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.Activity => "activity",
                GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.GroupAchievement => "groupAchievement",
                GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.Localizations => "localizations",
                GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.Activity,
                "gameCenterDetail" => GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.GroupAchievement,
                "localizations" => GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.Localizations,
                "releases" => GameCenterAchievementsGroupAchievementGetToOneRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}