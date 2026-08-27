
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterLeaderboards,
                "versions" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}