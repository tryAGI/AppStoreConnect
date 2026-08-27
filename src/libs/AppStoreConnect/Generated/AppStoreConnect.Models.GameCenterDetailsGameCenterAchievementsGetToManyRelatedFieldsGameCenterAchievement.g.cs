
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}