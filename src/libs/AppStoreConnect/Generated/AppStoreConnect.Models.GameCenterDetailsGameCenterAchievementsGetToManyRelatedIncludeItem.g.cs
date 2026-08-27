
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.GroupAchievement => "groupAchievement",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.Activity,
                "gameCenterDetail" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterGroup,
                "groupAchievement" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.GroupAchievement,
                "localizations" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}