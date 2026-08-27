
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem
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
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.Activity,
                "gameCenterDetail" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.GameCenterGroup,
                "versions" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}