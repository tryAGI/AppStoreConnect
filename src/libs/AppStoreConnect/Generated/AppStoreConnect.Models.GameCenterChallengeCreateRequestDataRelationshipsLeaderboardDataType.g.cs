
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataType value)
        {
            return value switch
            {
                GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}