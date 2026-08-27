
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeLeaderboardLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLeaderboardLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLeaderboardLinkageRequestDataType value)
        {
            return value switch
            {
                GameCenterChallengeLeaderboardLinkageRequestDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLeaderboardLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterChallengeLeaderboardLinkageRequestDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}