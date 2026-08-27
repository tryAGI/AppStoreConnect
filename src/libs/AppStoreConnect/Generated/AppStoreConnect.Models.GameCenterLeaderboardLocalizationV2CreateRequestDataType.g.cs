
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationV2CreateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationV2CreateRequestDataType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardLocalizationV2CreateRequestDataType.GameCenterLeaderboardLocalizations,
                _ => null,
            };
        }
    }
}