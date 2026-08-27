
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetV2RelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetVersions" => GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType.GameCenterLeaderboardSetVersions,
                _ => null,
            };
        }
    }
}