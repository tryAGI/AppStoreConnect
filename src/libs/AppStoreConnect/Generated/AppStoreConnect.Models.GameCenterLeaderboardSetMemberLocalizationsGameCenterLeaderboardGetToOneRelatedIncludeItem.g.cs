
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Activity => "activity",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Challenge => "challenge",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Localizations => "localizations",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Activity,
                "challenge" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Challenge,
                "gameCenterDetail" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Localizations,
                "releases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}