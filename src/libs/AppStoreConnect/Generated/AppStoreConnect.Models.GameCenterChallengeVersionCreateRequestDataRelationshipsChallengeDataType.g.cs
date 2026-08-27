
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionCreateRequestDataRelationshipsChallengeDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionCreateRequestDataRelationshipsChallengeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionCreateRequestDataRelationshipsChallengeDataType value)
        {
            return value switch
            {
                GameCenterChallengeVersionCreateRequestDataRelationshipsChallengeDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionCreateRequestDataRelationshipsChallengeDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterChallengeVersionCreateRequestDataRelationshipsChallengeDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}