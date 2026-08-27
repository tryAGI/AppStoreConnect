
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}