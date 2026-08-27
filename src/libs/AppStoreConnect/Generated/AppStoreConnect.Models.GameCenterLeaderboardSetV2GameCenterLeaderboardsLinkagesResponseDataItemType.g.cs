
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardSetV2GameCenterLeaderboardsLinkagesResponseDataItemType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}