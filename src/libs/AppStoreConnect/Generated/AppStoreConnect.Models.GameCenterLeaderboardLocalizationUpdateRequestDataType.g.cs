
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationUpdateRequestDataType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardLocalizationUpdateRequestDataType.GameCenterLeaderboardLocalizations,
                _ => null,
            };
        }
    }
}