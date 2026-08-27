
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Activity => "activity",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Archived => "archived",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Localizations => "localizations",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Points => "points",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.ReferenceName => "referenceName",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Releases => "releases",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Repeatable => "repeatable",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Activity,
                "activityProperties" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.ActivityProperties,
                "archived" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Localizations,
                "points" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Points,
                "referenceName" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.ReferenceName,
                "releases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Releases,
                "repeatable" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}