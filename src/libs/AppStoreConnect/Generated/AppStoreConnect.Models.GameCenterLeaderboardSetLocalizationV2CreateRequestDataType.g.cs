
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationV2CreateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationV2CreateRequestDataType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetLocalizationV2CreateRequestDataType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}