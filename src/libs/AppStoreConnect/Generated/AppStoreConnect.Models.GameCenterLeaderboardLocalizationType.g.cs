
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardLocalizationType.GameCenterLeaderboardLocalizations,
                _ => null,
            };
        }
    }
}