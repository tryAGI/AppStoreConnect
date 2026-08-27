
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge => "challenge",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GroupLeaderboard => "groupLeaderboard",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Activity,
                "challenge" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.GroupLeaderboard,
                "localizations" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}