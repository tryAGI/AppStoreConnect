
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeImageUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeImageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeImageUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeImageUpdateRequestDataType.GameCenterChallengeImages => "gameCenterChallengeImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeImageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeImageUpdateRequestDataType.GameCenterChallengeImages,
                _ => null,
            };
        }
    }
}