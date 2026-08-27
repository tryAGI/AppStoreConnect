
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGetInstanceFieldsGameCenterAchievement
    {
        /// <summary>
        /// 
        /// </summary>
        Activity,
        /// <summary>
        /// 
        /// </summary>
        ActivityProperties,
        /// <summary>
        /// 
        /// </summary>
        Archived,
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
        Points,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
        /// <summary>
        /// 
        /// </summary>
        Releases,
        /// <summary>
        /// 
        /// </summary>
        Repeatable,
        /// <summary>
        /// 
        /// </summary>
        ShowBeforeEarned,
        /// <summary>
        /// 
        /// </summary>
        VendorIdentifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsGetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Releases => "releases",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}