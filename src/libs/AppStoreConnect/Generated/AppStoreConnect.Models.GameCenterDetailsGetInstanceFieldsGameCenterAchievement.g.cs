
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterAchievement
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
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsGetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Releases => "releases",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterDetailsGetInstanceFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}