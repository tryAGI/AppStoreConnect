
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}