
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeAttributesChallengeType
    {
        /// <summary>
        /// 
        /// </summary>
        Leaderboard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeAttributesChallengeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeAttributesChallengeType value)
        {
            return value switch
            {
                GameCenterChallengeAttributesChallengeType.Leaderboard => "LEADERBOARD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeAttributesChallengeType? ToEnum(string value)
        {
            return value switch
            {
                "LEADERBOARD" => GameCenterChallengeAttributesChallengeType.Leaderboard,
                _ => null,
            };
        }
    }
}