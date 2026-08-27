
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsGetInstanceIncludeItem
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
    public static class GameCenterLeaderboardsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardsGetInstanceIncludeItem.Activity => "activity",
                GameCenterLeaderboardsGetInstanceIncludeItem.Challenge => "challenge",
                GameCenterLeaderboardsGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGetInstanceIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardsGetInstanceIncludeItem.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardsGetInstanceIncludeItem.Localizations => "localizations",
                GameCenterLeaderboardsGetInstanceIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardsGetInstanceIncludeItem.Activity,
                "challenge" => GameCenterLeaderboardsGetInstanceIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterLeaderboardsGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGetInstanceIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardsGetInstanceIncludeItem.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardsGetInstanceIncludeItem.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardsGetInstanceIncludeItem.Localizations,
                "releases" => GameCenterLeaderboardsGetInstanceIncludeItem.Releases,
                _ => null,
            };
        }
    }
}