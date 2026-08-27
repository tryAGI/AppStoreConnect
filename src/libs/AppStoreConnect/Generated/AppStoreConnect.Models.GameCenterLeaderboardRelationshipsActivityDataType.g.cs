
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardRelationshipsActivityDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardRelationshipsActivityDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardRelationshipsActivityDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardRelationshipsActivityDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardRelationshipsActivityDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterLeaderboardRelationshipsActivityDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}