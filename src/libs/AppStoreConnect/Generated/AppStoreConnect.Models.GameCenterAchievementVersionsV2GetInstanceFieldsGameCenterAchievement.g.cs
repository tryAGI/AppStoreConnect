
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement
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
    public static class GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "points" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.ReferenceName,
                "repeatable" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}