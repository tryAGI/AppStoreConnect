
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}