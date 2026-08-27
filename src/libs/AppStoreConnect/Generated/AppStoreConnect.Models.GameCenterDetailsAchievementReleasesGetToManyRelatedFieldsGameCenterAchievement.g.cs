
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement
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
    public static class GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Activity => "activity",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Archived => "archived",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Points => "points",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Releases => "releases",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}