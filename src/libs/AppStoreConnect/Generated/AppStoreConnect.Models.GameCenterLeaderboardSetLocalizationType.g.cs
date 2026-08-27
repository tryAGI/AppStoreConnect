
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetLocalizationType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}