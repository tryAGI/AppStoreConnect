
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationType value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationType.GameCenterChallengeLocalizations => "gameCenterChallengeLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeLocalizations" => GameCenterChallengeLocalizationType.GameCenterChallengeLocalizations,
                _ => null,
            };
        }
    }
}