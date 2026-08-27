
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeUpdateRequestDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterChallengeUpdateRequestDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}