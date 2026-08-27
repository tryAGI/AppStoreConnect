
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionInlineCreateRelationshipsChallengeDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionInlineCreateRelationshipsChallengeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionInlineCreateRelationshipsChallengeDataType value)
        {
            return value switch
            {
                GameCenterChallengeVersionInlineCreateRelationshipsChallengeDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionInlineCreateRelationshipsChallengeDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterChallengeVersionInlineCreateRelationshipsChallengeDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}