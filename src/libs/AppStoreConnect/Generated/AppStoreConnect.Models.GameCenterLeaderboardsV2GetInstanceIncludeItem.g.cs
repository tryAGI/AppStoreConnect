
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsV2GetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Activity,
        /// <summary>
        /// 
        /// </summary>
        Challenge,
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
        GameCenterLeaderboardSets,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GetInstanceIncludeItem.Activity => "activity",
                GameCenterLeaderboardsV2GetInstanceIncludeItem.Challenge => "challenge",
                GameCenterLeaderboardsV2GetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsV2GetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsV2GetInstanceIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardsV2GetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardsV2GetInstanceIncludeItem.Activity,
                "challenge" => GameCenterLeaderboardsV2GetInstanceIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterLeaderboardsV2GetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsV2GetInstanceIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardsV2GetInstanceIncludeItem.GameCenterLeaderboardSets,
                "versions" => GameCenterLeaderboardsV2GetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}