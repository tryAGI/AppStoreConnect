
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeCreateRequestDataAttributesChallengeType
    {
        /// <summary>
        ///
        /// </summary>
        Leaderboard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeCreateRequestDataAttributesChallengeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeCreateRequestDataAttributesChallengeType value)
        {
            return value switch
            {
                GameCenterChallengeCreateRequestDataAttributesChallengeType.Leaderboard => "LEADERBOARD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeCreateRequestDataAttributesChallengeType? ToEnum(string value)
        {
            return value switch
            {
                "LEADERBOARD" => GameCenterChallengeCreateRequestDataAttributesChallengeType.Leaderboard,
                _ => null,
            };
        }
    }
}