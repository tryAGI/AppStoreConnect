
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsGetInstanceIncludeItem
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
        GroupLeaderboardSet,
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
    public static class GameCenterLeaderboardSetsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGetInstanceIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsGetInstanceIncludeItem.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterLeaderboardSetsGetInstanceIncludeItem.Localizations => "localizations",
                GameCenterLeaderboardSetsGetInstanceIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsGetInstanceIncludeItem.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsGetInstanceIncludeItem.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterLeaderboardSetsGetInstanceIncludeItem.GroupLeaderboardSet,
                "localizations" => GameCenterLeaderboardSetsGetInstanceIncludeItem.Localizations,
                "releases" => GameCenterLeaderboardSetsGetInstanceIncludeItem.Releases,
                _ => null,
            };
        }
    }
}