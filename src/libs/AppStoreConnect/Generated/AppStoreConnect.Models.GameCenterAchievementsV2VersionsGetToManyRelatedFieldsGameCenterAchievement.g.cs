
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement
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
        Points,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
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
    public static class GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "points" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "repeatable" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}