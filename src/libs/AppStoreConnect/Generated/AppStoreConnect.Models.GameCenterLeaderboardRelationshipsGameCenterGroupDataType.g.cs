
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardRelationshipsGameCenterGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardRelationshipsGameCenterGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardRelationshipsGameCenterGroupDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardRelationshipsGameCenterGroupDataType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardRelationshipsGameCenterGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterGroups" => GameCenterLeaderboardRelationshipsGameCenterGroupDataType.GameCenterGroups,
                _ => null,
            };
        }
    }
}