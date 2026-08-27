
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetailDataType.GameCenterDetails,
                _ => null,
            };
        }
    }
}