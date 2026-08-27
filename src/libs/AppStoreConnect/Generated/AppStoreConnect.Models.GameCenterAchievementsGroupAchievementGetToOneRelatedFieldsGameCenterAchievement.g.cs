
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement
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
    public static class GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}