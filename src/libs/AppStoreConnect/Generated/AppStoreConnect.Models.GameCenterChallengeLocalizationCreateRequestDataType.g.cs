
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationCreateRequestDataType.GameCenterChallengeLocalizations => "gameCenterChallengeLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeLocalizations" => GameCenterChallengeLocalizationCreateRequestDataType.GameCenterChallengeLocalizations,
                _ => null,
            };
        }
    }
}