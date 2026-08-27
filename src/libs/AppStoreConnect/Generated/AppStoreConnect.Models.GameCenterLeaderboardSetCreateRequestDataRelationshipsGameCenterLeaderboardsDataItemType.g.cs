
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}