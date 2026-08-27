
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}