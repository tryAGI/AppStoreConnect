
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}