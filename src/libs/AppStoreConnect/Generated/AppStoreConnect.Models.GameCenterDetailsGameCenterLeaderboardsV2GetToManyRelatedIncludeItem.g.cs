
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Challenge => "challenge",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Activity,
                "challenge" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterLeaderboardSets,
                "versions" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}