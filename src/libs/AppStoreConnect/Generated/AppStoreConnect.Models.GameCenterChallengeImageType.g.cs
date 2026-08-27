
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeImageType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeImageType value)
        {
            return value switch
            {
                GameCenterChallengeImageType.GameCenterChallengeImages => "gameCenterChallengeImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeImageType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeImageType.GameCenterChallengeImages,
                _ => null,
            };
        }
    }
}