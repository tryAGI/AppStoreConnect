
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType value)
        {
            return value switch
            {
                GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}