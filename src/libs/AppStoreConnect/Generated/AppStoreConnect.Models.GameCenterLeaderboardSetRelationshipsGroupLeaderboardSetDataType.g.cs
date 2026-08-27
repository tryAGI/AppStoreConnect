
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}