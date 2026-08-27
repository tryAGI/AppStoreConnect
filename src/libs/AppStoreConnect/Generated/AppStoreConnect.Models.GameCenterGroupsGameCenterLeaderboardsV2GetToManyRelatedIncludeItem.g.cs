
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem
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
    public static class GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Challenge => "challenge",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Activity,
                "challenge" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.GameCenterLeaderboardSets,
                "versions" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}