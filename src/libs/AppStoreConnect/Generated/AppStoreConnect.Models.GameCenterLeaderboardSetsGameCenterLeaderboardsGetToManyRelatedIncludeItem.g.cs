
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem
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
        GroupLeaderboard,
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
    public static class GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge => "challenge",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity,
                "challenge" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}