
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsV2GetInstanceIncludeItem
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
    public static class GameCenterAchievementsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementsV2GetInstanceIncludeItem.Activity => "activity",
                GameCenterAchievementsV2GetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsV2GetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsV2GetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterAchievementsV2GetInstanceIncludeItem.Activity,
                "gameCenterDetail" => GameCenterAchievementsV2GetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsV2GetInstanceIncludeItem.GameCenterGroup,
                "versions" => GameCenterAchievementsV2GetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}