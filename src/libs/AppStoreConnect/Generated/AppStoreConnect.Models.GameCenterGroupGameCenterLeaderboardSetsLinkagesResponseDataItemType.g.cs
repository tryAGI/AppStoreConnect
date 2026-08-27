
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSets" => GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}