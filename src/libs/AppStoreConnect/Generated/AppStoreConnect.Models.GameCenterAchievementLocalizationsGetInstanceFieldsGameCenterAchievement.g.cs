
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement
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
    public static class GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Releases => "releases",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                _ => null,
            };
        }
    }
}