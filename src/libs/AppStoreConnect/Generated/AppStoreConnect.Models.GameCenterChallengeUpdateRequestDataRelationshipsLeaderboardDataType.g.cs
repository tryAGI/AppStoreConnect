
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardDataType value)
        {
            return value switch
            {
                GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}