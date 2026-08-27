
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeCreateRequestDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterChallengeCreateRequestDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}