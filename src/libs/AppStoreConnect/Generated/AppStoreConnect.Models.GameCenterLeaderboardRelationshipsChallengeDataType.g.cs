
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardRelationshipsChallengeDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardRelationshipsChallengeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardRelationshipsChallengeDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardRelationshipsChallengeDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardRelationshipsChallengeDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterLeaderboardRelationshipsChallengeDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}