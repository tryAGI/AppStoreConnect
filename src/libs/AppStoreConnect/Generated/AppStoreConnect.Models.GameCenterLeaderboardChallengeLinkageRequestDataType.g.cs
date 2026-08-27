
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardChallengeLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardChallengeLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardChallengeLinkageRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardChallengeLinkageRequestDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardChallengeLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterLeaderboardChallengeLinkageRequestDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}