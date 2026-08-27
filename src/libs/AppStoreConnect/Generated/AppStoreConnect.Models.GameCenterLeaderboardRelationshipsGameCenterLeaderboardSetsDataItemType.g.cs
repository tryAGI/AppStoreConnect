
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}