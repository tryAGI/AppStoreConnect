
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityLeaderboardsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLeaderboardsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLeaderboardsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterActivityLeaderboardsLinkagesRequestDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLeaderboardsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterActivityLeaderboardsLinkagesRequestDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}