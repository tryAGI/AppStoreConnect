
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Activity,
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
        Releases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.Activity => "activity",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.GroupAchievement => "groupAchievement",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.Localizations => "localizations",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.Activity,
                "gameCenterDetail" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.GameCenterGroup,
                "groupAchievement" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.GroupAchievement,
                "localizations" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.Localizations,
                "releases" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}