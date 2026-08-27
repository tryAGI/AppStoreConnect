
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}