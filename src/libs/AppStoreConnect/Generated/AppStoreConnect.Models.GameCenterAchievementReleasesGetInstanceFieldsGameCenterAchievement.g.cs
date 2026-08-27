
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement
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
    public static class GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Releases => "releases",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}