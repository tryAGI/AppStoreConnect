
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGetCollectionFieldsGameCenterAchievement
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
    public static class GameCenterGroupsGetCollectionFieldsGameCenterAchievementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionFieldsGameCenterAchievement value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Activity => "activity",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.ActivityProperties => "activityProperties",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Archived => "archived",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.GroupAchievement => "groupAchievement",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Localizations => "localizations",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Points => "points",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.ReferenceName => "referenceName",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Releases => "releases",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Repeatable => "repeatable",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.ShowBeforeEarned => "showBeforeEarned",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionFieldsGameCenterAchievement? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Activity,
                "activityProperties" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.ActivityProperties,
                "archived" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Archived,
                "gameCenterDetail" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.GameCenterGroup,
                "groupAchievement" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.GroupAchievement,
                "localizations" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Localizations,
                "points" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Points,
                "referenceName" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.ReferenceName,
                "releases" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Releases,
                "repeatable" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Repeatable,
                "showBeforeEarned" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.ShowBeforeEarned,
                "vendorIdentifier" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.VendorIdentifier,
                "versions" => GameCenterGroupsGetCollectionFieldsGameCenterAchievement.Versions,
                _ => null,
            };
        }
    }
}