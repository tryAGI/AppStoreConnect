
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2RelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2RelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2RelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2RelationshipsVersionsDataItemType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2RelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardVersions" => GameCenterLeaderboardV2RelationshipsVersionsDataItemType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}