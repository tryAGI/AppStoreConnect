
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GetInstanceIncludeItem
    {
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
        GameCenterLeaderboards,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsV2GetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsV2GetInstanceIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsV2GetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsV2GetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsV2GetInstanceIncludeItem.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsV2GetInstanceIncludeItem.GameCenterLeaderboards,
                "versions" => GameCenterLeaderboardSetsV2GetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}