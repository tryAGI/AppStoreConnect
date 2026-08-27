
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement
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
    public static class GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}