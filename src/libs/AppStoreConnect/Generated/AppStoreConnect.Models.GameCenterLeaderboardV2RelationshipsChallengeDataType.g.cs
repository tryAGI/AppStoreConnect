
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2RelationshipsChallengeDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2RelationshipsChallengeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2RelationshipsChallengeDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2RelationshipsChallengeDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2RelationshipsChallengeDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterLeaderboardV2RelationshipsChallengeDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}