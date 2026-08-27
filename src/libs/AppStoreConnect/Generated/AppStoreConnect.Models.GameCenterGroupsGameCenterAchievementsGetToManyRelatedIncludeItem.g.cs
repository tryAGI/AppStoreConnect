
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem
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
    public static class GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.GroupAchievement => "groupAchievement",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.Activity,
                "gameCenterDetail" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.GameCenterGroup,
                "groupAchievement" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.GroupAchievement,
                "localizations" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}