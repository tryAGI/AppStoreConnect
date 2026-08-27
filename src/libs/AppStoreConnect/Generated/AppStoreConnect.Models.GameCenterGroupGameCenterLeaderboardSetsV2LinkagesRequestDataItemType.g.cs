
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}