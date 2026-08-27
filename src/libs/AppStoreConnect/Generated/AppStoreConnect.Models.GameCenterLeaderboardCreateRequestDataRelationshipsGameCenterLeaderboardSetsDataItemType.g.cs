
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterLeaderboardSetsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterLeaderboardSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterLeaderboardSetsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterLeaderboardSetsDataItemType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterLeaderboardSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterLeaderboardSetsDataItemType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}