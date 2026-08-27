
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}