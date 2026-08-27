
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}