
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "points" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "repeatable" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}