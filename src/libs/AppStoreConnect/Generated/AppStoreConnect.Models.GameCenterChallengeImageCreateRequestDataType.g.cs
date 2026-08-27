
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeImageCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeImageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeImageCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeImageCreateRequestDataType.GameCenterChallengeImages => "gameCenterChallengeImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeImageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeImages" => GameCenterChallengeImageCreateRequestDataType.GameCenterChallengeImages,
                _ => null,
            };
        }
    }
}