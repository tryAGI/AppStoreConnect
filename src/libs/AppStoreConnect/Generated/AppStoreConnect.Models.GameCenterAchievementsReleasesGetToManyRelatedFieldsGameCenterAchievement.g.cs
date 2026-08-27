
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementsReleasesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}