
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem
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
    public static class GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.Localizations => "localizations",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.GroupLeaderboardSet,
                "localizations" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.Localizations,
                "releases" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}