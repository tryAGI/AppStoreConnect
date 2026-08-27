
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement
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
    public static class GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "points" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.ReferenceName,
                "repeatable" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}