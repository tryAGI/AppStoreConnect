
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2ChallengeLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2ChallengeLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2ChallengeLinkageRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2ChallengeLinkageRequestDataType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2ChallengeLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterLeaderboardV2ChallengeLinkageRequestDataType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}