
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetInstanceFieldsGameCenterAchievement
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
    public static class GameCenterGroupsGetInstanceFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Activity => "activity",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Archived => "archived",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Points => "points",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Releases => "releases",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterGroupsGetInstanceFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}