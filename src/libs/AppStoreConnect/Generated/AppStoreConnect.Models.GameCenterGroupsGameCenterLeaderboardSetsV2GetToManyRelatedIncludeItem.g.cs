
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem
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
    public static class GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.GameCenterLeaderboards,
                "versions" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}