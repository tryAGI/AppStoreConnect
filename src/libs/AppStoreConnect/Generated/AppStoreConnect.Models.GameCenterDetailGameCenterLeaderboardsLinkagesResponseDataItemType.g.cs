
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}