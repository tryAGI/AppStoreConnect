
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterScoreModerationRelationshipsPlayerDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetailPlayers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterScoreModerationRelationshipsPlayerDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterScoreModerationRelationshipsPlayerDataType value)
        {
            return value switch
            {
                GameCenterScoreModerationRelationshipsPlayerDataType.GameCenterDetailPlayers => "gameCenterDetailPlayers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterScoreModerationRelationshipsPlayerDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetailPlayers" => GameCenterScoreModerationRelationshipsPlayerDataType.GameCenterDetailPlayers,
                _ => null,
            };
        }
    }
}