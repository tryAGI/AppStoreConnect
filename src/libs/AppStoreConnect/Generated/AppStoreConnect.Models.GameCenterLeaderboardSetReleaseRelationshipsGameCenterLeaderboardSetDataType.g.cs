
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}