
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}