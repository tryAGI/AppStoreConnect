
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "points" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "repeatable" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}