
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetMemberLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetMemberLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationType.GameCenterLeaderboardSetMemberLocalizations => "gameCenterLeaderboardSetMemberLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetMemberLocalizations" => GameCenterLeaderboardSetMemberLocalizationType.GameCenterLeaderboardSetMemberLocalizations,
                _ => null,
            };
        }
    }
}