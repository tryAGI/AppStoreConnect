
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem
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
    public static class GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge => "challenge",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity,
                "challenge" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets,
                "versions" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}