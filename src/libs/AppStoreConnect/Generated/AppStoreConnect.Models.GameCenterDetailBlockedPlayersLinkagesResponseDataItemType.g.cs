
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailBlockedPlayersLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetailPlayers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailBlockedPlayersLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailBlockedPlayersLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailBlockedPlayersLinkagesResponseDataItemType.GameCenterDetailPlayers => "gameCenterDetailPlayers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailBlockedPlayersLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetailPlayers" => GameCenterDetailBlockedPlayersLinkagesResponseDataItemType.GameCenterDetailPlayers,
                _ => null,
            };
        }
    }
}