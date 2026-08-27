
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationUpdateRequestDataType.GameCenterChallengeLocalizations => "gameCenterChallengeLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeLocalizations" => GameCenterChallengeLocalizationUpdateRequestDataType.GameCenterChallengeLocalizations,
                _ => null,
            };
        }
    }
}