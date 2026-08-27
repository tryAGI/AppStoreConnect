
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem
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
    public static class GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge => "challenge",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GroupLeaderboard => "groupLeaderboard",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity,
                "challenge" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GroupLeaderboard,
                "localizations" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}