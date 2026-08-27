
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}