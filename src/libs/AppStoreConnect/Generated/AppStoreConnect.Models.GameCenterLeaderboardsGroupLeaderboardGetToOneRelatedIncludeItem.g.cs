
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem
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
    public static class GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Activity => "activity",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Challenge => "challenge",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Localizations => "localizations",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Activity,
                "challenge" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Localizations,
                "releases" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}