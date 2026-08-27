
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}