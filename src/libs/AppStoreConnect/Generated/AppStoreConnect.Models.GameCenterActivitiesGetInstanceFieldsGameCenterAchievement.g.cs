
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivitiesGetInstanceFieldsGameCenterAchievement
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
    public static class GameCenterActivitiesGetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesGetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Releases => "releases",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesGetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterActivitiesGetInstanceFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}