
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}