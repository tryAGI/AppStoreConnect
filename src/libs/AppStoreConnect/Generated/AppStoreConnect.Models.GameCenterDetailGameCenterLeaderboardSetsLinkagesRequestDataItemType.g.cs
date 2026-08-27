
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}