
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2DataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2DataType value)
        {
            return value switch
            {
                GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2DataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2DataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}