
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGetInstanceIncludeItem
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
    public static class GameCenterAchievementsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementsGetInstanceIncludeItem.Activity => "activity",
                GameCenterAchievementsGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsGetInstanceIncludeItem.GroupAchievement => "groupAchievement",
                GameCenterAchievementsGetInstanceIncludeItem.Localizations => "localizations",
                GameCenterAchievementsGetInstanceIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsGetInstanceIncludeItem.Activity,
                "gameCenterDetail" => GameCenterAchievementsGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsGetInstanceIncludeItem.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementsGetInstanceIncludeItem.GroupAchievement,
                "localizations" => GameCenterAchievementsGetInstanceIncludeItem.Localizations,
                "releases" => GameCenterAchievementsGetInstanceIncludeItem.Releases,
                _ => null,
            };
        }
    }
}