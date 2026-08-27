
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement
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
    public static class GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}